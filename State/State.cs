using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    /// <summary>

    /// The 'Context' class

    /// </summary>

    class Context

    {
        private StateSample _state;

        // Constructor

        public Context(StateSample state)
        {
            this.State = state;
        }

        // Gets or sets the state

        public StateSample State
        {
            get { return _state; }
            set

            {
                _state = value;
                Console.WriteLine("State: " +
                                  _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }


    /// <summary>

    /// The 'State' abstract class

    /// </summary>

    abstract class StateSample

    {
        public abstract void Handle(Context context);
    }

    /// <summary>

    /// A 'ConcreteState' class

    /// </summary>

    class ConcreteStateA : StateSample

    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    /// <summary>

    /// A 'ConcreteState' class

    /// </summary>

    class ConcreteStateB : StateSample

    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }


}
