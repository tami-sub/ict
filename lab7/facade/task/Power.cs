using System;
namespace task
{
    public class Power
    {
        public event EventHandler powerevent;

        private int _power;

        public int MicrowavePower
        {
            get { return _power; }
            set
            {
                _power = value;

                if (powerevent != null)
                    powerevent(this, new EventArgs());
            }
        }
    }
}
