using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeeveEngine.TeeveEngine {
    public class Vector2 {
        public float Y { get; set; }
        public float X { get; set; }


        public Vector2() {
            X = Zero().X;
            Y = Zero().Y;
        }

        public Vector2(float x, float y) {
            X = x;
            Y = y;
        }

        public static Vector2 Zero() {
            return new Vector2(0, 0);
        }
    }
}
