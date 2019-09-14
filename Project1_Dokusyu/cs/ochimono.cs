//	C#	Windows Forms

using System;
using jp.netgamers.free.tugame;		//	拙作ライブラリ

public class ochimono : TUGame
{
	static readonly int		WIDTH = 14;
	static readonly int		HEIGHT = 24;

	static uint[]			m_argb = { 0xff000000, 0xffffffff, 0xff00ff00 };
	static byte[]			m_field = new byte[ WIDTH * HEIGHT ];

	static int				m_x, m_y;
	static int				m_rotate;

	//	起動イベント通知
	public override void wmLoad() 
	{
		setStartLocation( 0, 61 );	//	起動時のウィンドウ位置。キャプチャ都合上
		setBackground( 0xff005555 );

		for( int x = 1; x < WIDTH - 1; x++ ){
			setField( x,          1, 1 );
			setField( x, HEIGHT - 2, 1 );
		}

		for( int y = 1; y < HEIGHT - 1; y++ ){
			setField(         1, y, 1 );
			setField( WIDTH - 2, y, 1 );
		}

		next();

		setFrameRate( 10 );
	}

	//	描画イベント通知
	public override void wmPaint()
	{
		//	フィールドの描画
		for( int y = 0; y < HEIGHT; y++ ){
			for( int x = 0; x < WIDTH; x++ ){
				drawBlock( x, y, getField( x, y ) );
			}
		}

		//	操作中のブロック
		if( m_rotate == 0 ){
			drawBlock( m_x    , m_y + 1, 2 );
			drawBlock( m_x + 1, m_y + 1, 2 );
			drawBlock( m_x + 2, m_y + 1, 2 );
			drawBlock( m_x + 3, m_y + 1, 2 );
		}else{
			drawBlock( m_x + 1, m_y    , 2 );
			drawBlock( m_x + 1, m_y + 1, 2 );
			drawBlock( m_x + 1, m_y + 2, 2 );
			drawBlock( m_x + 1, m_y + 3, 2 );
		}
	}

	//	タイマーイベント通知
	public override void wmTimer()
	{
		if( !fall() ){
			if( m_rotate == 0 ){
				setField( m_x    , m_y + 1, 2 );
				setField( m_x + 1, m_y + 1, 2 );
				setField( m_x + 2, m_y + 1, 2 );
				setField( m_x + 3, m_y + 1, 2 );
			}else{
				setField( m_x + 1, m_y    , 2 );
				setField( m_x + 1, m_y + 1, 2 );
				setField( m_x + 1, m_y + 2, 2 );
				setField( m_x + 1, m_y + 3, 2 );
			}

			for( int i = 0; i < 4; i++ ){
				if( isLine( m_y + i ) ){
					clearLine( m_y + i );
				}
			}

			next();
		}

		if( TUKeyPad.isRight() )	tryMove(  1, 0 );
		if( TUKeyPad.isLeft() )		tryMove( -1, 0 );
		if( TUKeyPad.isDown() )		tryMove(  0, 1 );

		if( TUKeyPad.isA() ){
			m_rotate = 1 - m_rotate;
		}

		repaint();
	}

	void next()
	{
		m_x = WIDTH / 2 - 2;
		m_y = 2;
		m_rotate = 0;
	}

	bool fall()
	{
		return( tryMove( 0, 1 ) );
	}

	bool tryMove( int dx, int dy )
	{
		if( !isMove( dx, dy ) ){
			return( false );
		}
		m_x += dx;
		m_y += dy;
		return( true );
	}

	bool isMove( int dx, int dy )
	{
		if( m_rotate == 0 ){
			return( getField( m_x + dx    , m_y + dy + 1 ) == 0 &&
			        getField( m_x + dx + 1, m_y + dy + 1 ) == 0 &&
			        getField( m_x + dx + 2, m_y + dy + 1 ) == 0 &&
			        getField( m_x + dx + 3, m_y + dy + 1 ) == 0 );
		}else{
			return( getField( m_x + dx + 1, m_y + dy     ) == 0 &&
			        getField( m_x + dx + 1, m_y + dy + 1 ) == 0 &&
			        getField( m_x + dx + 1, m_y + dy + 2 ) == 0 &&
			        getField( m_x + dx + 1, m_y + dy + 3 ) == 0 );
		}
	}

	void drawBlock( int x, int y, byte t )
	{
		setColor( m_argb[ t ] );			//	描画色を設定
		fillRect( x * 15, y * 15, 14, 14 );	//	矩形描画
	}

	bool isLine( int y )
	{
		for( int x = 2; x < WIDTH - 2; x++ ){
			if( getField( x, y ) < 2 ){
				return( false );
			}
		}
		return( true );
	}

	void clearLine( int y )
	{
		for( int x = 2; x < WIDTH - 2; x++ ){
			for( int i = y; i > 2; i-- ){
				setField( x, i, getField( x, i - 1 ) );
			}
		}

		for( int x = 2; x < WIDTH - 2; x++ ){
			setField( x, 2, 0 );
		}
	}

	byte getField( int x, int y )
	{
		return( m_field[ y * WIDTH + x ] );
	}

	void setField( int x, int y, byte t )
	{
		m_field[ y * WIDTH + x ] = t;
	}

	[STAThread]
	static void Main()
	{
		setClientSize( 480, 360 );		//	ウィンドウサイズを設定
		new ochimono();
	}
}
