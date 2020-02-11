using System;

namespace interfazNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ICharlatan loro = new Loro("Ave","Voladora");
                        
            loro.hablar();


        }
    }


    interface ICharlatan{

        public void hablar();

    }

    abstract class Animal : ICharlatan{

        private string especie;

        public Animal(string especie){

            this.especie = especie;

        }

        public virtual void hablar(){          

            Console.WriteLine("Hablamos");

        }

    }

    class Loro : Animal{

        private string tipo;

        public Loro(string especie,string tipo) : base(especie){

            this.tipo = tipo;

        }

        public override void hablar(){

            //base.hablar();
            Console.WriteLine("Muy poco");


        }


    }

    class Delfin : Animal{
        private string tipo;

        public Delfin(string especie,string tipo) : base(especie){

            this.tipo = tipo;

        }


    }

    class Tortuga : Animal{

        private string tipo;

        public Tortuga(string especie,string tipo) : base(especie){

            this.tipo = tipo;

        }

    }




}
