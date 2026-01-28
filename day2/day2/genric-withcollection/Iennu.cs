// using System.Collections;
// class ienu :IEnumerable{
//     int []i={1,2,3,4};
//     IEnumerator IEnumerable.GetEnumerator(){
//         return i.GetEnumerator();
//     }
// }

// class Mother{
//     public static void Main(){
//         ienu obj =new ienu();
//         foreach(var j in obj)// at this point getenumerator will call automatically
//         {
//             Console.WriteLine(j);    
//         }
//         }
// }