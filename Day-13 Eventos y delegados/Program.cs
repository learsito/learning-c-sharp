//Eventos y delegados
    //Delegados:
        /*
            Es un tipo que puede contener una referencia a un método. Cuando llamas a un delegado,
            estás llamando al mismo tiempo al método al que este hace referencia.
        */
        
        //Ejemplo de delegado
/*
        void ClickBotonEnviar(){
            Network.Connect();
            Network.SendMessage();
            DisplayMessageSentDialog();
        }

        ClickBotonEnviar.Onclick= ClickBotonEnviar;

        if(isMouseHovering&&isLeftClickPressed){
            ClickBotonEnviar.OnClick();
        }

        private delegate void DelegadoOnClick();
        public DelegadoOnClick OnClick;
        */

        //Crear delegados simples y multidifusión
            static void MiMain(){
                HacerCalculo miSuma = Suma;
                miSuma(5.0,5.0);
                HacerCalculo miDivision = Division;
                miDivision(5.0,5.0);
                HacerCalculo calculoMultiple = miSuma + miDivision;
                calculoMultiple += Resta;
                calculoMultiple -= miSuma;
                calculoMultiple(3.2,3.2);
            }

                MiMain();

            static double Suma(double a, double b){
                Console.WriteLine("A+b es: "+(a+b));
                return a + b;
            }

            static double Division(double a, double b){
                Console.WriteLine("A/b es: "+(a/b));
                return a / b;
            }

            static double Resta(double a, double b){
                Console.WriteLine("A-b es: "+(a-b));
                return a - b;
            }

            public delegate double HacerCalculo(double x, double y);

            