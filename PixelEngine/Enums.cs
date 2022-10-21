namespace PixelEngine
{
	public enum Key
	{
		A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z,
		K0, K1, K2, K3, K4, K5, K6, K7, K8, K9,
		F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12,
		Up, Down, Left, Right,
		Space, Tab, Shift, Control, Alt, Insert, Delete, Home, End, PageUp, PageDown,
		Back, Escape, Enter, Pause, Scroll, 
		
		// OEM keys, may vary			// US standard mappings [unshiftSHIFT]
		OEM_1, SemiColon = OEM_1,		// [;:]
		OEM_2, Slash = OEM_2,			// [/?]
		OEM_3, Grave = OEM_3,			// [`~]
		OEM_4, OSquareBracket = OEM_4,	// [[{]
		OEM_5, Backslash = OEM_5,		// [\|]
		OEM_6, CSquareBracket = OEM_6,	// []}]
		OEM_7, Quote = OEM_7,			// ['"]
		OEM_8,
		OEM_PLUS, Plus = OEM_PLUS,		// [=+]
		OEM_MINUS, Minus = OEM_MINUS,	// [-_]
		OEM_COMMA, Comma = OEM_COMMA,	// [,<]
		OEM_PERIOD, Period = OEM_PERIOD,// [.>]

		// default values
		Any, None
	}

	public enum Mouse
	{
		Left,
		Middle,
		Right,
		Any,
		None
	}

	public enum Scroll
	{
		Up = -1,
		None = 0,
		Down = 1
	}
}
