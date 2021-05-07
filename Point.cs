using System.Collections.Generic;
using System.Threading;

namespace Slimulator {
    public enum PointType {
        Wall,
        Space,
        Slime,
        Food
    };

    public class Point {
        private PointType _type;
        private int _slimeAffinity;
        private int x;

        public PointType Type => _type;

        public int SlimeAffinity => _slimeAffinity;

        public int X => x;

        public int Y => y;

        private int y;

        public Point(int x, int y,PointType pt) {
            _type = pt;
            this.x = x;
            this.y = y;
            switch (pt) {
                case PointType.Space:
                    _slimeAffinity = 10;
                    break;
                case PointType.Wall:
                    _slimeAffinity = -1;
                    break;
                case PointType.Food:
                    _slimeAffinity = 1000;
                    break;
                case PointType.Slime:
                    _slimeAffinity = 1;
                    break;
            }
        }

        public Point(int x, int y, PointType pt, int lop) {
            this.x = x;
            this.y = y;
            _type = pt;
            _slimeAffinity = lop;
        }

        public void SetType(PointType pt) {
            this._type = pt;
        }
        
        public int GetSlimeAffinity() => _slimeAffinity;
        public new PointType GetType() => _type;
        
    }
}