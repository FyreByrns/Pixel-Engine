namespace PixelEngine {
    public static class V2X {
        public static Vector2 Along(this Vector2 me, float dist, float r) =>
            Vector2.Along(me, dist, r);

        public static Point[] ToPointArr(this Vector2[] v) {
            Point[] result = new Point[v.Length];
            for (int i = 0; i < v.Length; i++) {
                result[i] = v[i];
            }
            return result;
        }
    }

    public struct Vector2 {
        public float x, y;

        public float Length2 => x * x + y * y;
        public float Length => (float)Math.Sqrt(Length2);

        public Vector2 RawNormal =>
            new Vector2(y, -x);
        public Vector2 Normal =>
            RawNormal.Normalized();

        public Vector2 Normalized() {
            Vector2 result = new Vector2();

            if (Length > 0) {
                result.x = x / Length;
                result.y = y / Length;
            }

            return result;
        }

        public float DotProduct(Vector2 other) =>
                DotProduct(this, other);

        public Vector2 Project(Vector2 onto) =>
                    Project(this, onto);

        public static float DotProduct(Vector2 va, Vector2 vb) =>
                 va.x * vb.x + va.y * vb.y;
        public static float CrossProduct(Vector2 v1, Vector2 v2) =>
            (v1.x * v2.y) - (v1.y * v2.x);

        public static Vector2 Project(Vector2 v, Vector2 onto) {
            float dp = DotProduct(v, onto);
            return onto * dp;
        }

        public static Vector2 Along(Vector2 origin, float distance, float rotation) =>
            new Vector2((float)(origin.x + Math.Sin(rotation) * distance), (float)(origin.y + Math.Cos(rotation) * distance));

        public static bool operator ==(Vector2 va, Vector2 vb) =>
                 va.x == vb.x &&
                 va.y == vb.y;

        public static bool operator !=(Vector2 va, Vector2 vb) =>
                !(va == vb);

        public static Vector2 operator +(Vector2 va, Vector2 vb) =>
                new Vector2(va.x + vb.x,
                                va.y + vb.y);
        public static Vector2 operator -(Vector2 va, Vector2 vb) =>
                new Vector2(va.x - vb.x,
                                va.y - vb.y);

        public static Vector2 operator +(Vector2 v, float scalar) =>
            v + new Vector2(scalar, scalar);
        public static Vector2 operator -(Vector2 v, float scalar) =>
            v - new Vector2(scalar, scalar);

        public static Vector2 operator *(Vector2 va, Vector2 vb) =>
            new Vector2(va.x * vb.x, va.y * vb.y);
        public static Vector2 operator /(Vector2 va, Vector2 vb) =>
            new Vector2(va.x / vb.x, va.y / vb.y);

        public static Vector2 operator *(Vector2 v, float f) =>
            new Vector2(v.x * f, v.y * f);
        public static Vector2 operator /(Vector2 v, float f) =>
            new Vector2(v.x / f, v.y / f);
        public static Vector2 operator *(float scalar, Vector2 v) =>
            v * scalar;
        public static Vector2 operator /(float scalar, Vector2 v) =>
            v / scalar;

        public Vector2(Vector2 v) {
            x = v.x;
            y = v.y;
        }
        public Vector2(float x, float y) {
            this.x = x;
            this.y = y;
        }
        public Vector2(float? x, float? y) {
            this.x = x ?? default;
            this.y = y ?? default;
        }

        public override int GetHashCode() =>
                x.GetHashCode() * 13 + y.GetHashCode() * 13;

        public override bool Equals(object obj) =>
                obj is Vector2 v && v == this;

        public static implicit operator PixelEngine.Point(Vector2 v) {
            return new PixelEngine.Point((int)v.x, (int)v.y);
        }

        public static implicit operator Vector2(PixelEngine.Point p) {
            return (p.X, p.Y);
        }

        public static implicit operator Vector2((float a, float b) t) =>
            new Vector2(t.a, t.b);

        public static float AngleBetween(Vector2 a, Vector2 b) {
            float dx = b.x - a.x;
            float dy = a.y - b.y;
            return (float)Math.Atan2(dy, dx) - (float)(Math.PI / 180d * 90d);
        }

        public static Vector2 Zero => new Vector2(0, 0);

        public static Vector2 Round(Vector2 v) {
            return ((float)Math.Round(v.x), (float)Math.Round(v.y));
        }
        public static Vector2 Floor(Vector2 v) {
            return ((float)Math.Floor(v.x), (float)Math.Floor(v.y));
        }
    }
}
