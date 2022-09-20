using System;

namespace cursoIntroCS
{
    class program
    {
        static void Main(string[] args)
        {
            /*all word whit * (word*) indicated optional o*/
            /* ARRAYS:  declaracion:
             Type[] nameArray =New Type* [size*]*/
            Console.WriteLine("long of the array");
            int fullNum = int.Parse(Console.ReadLine());
            int final = fullNum + 1;
            int[] array = new[] { 2, 3, 4 };
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("ingresar el " + (i + 1) + " numero ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            /*LISTAS EN CS
             Son una colección de datos del mismo tipo, como los arrays,
            a diferencia de que en una lista podemos añadir y quitar datos fácilmente y cuando queramos.
             List<Type> nameList =new List<Type>();
                para añadir: 
                    nameList.add ("what you want");
                insertar en cualquier punto, desplazando los demas:
                    nameList.insert (position,"What u Want";

             */
            List<string> tacoShoppingList = new List<string>();
            tacoShoppingList.Add("cinco tacos de monda");
            tacoShoppingList.Add("4 no se ");
            tacoShoppingList.Add("3 cocas");
             
            /* para recogger la lista se usa el comando count*/
            for (int i = 0; i < tacoShoppingList.Count; i++) { }

         
        }

     
    }
}















































