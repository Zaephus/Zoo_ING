
using System.Collections;

namespace Zoo {

    public interface IHerbivore {
        public void EatLeaves();
    }

    public interface ICarnivore {
        public void EatMeat();
    }

    public interface ITrickable {
        public void PerformTrick();
        public IEnumerator DoTrick();
    }

}