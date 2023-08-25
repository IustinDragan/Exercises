using GenericsExercises.Ex5;
using GenericsExercises.Ex6;
using GenericsExercises.Ex8;
using GenericsExercises.Ex1;
using GenericsExercises.Ex2;
using GenericsExercises.Ex3;
using GenericsExercises.Ex4;

 MainEx1.ExecuteEx1_int();
 MainEx1.ExecuteEx1_string();

 MainEx2.ExecuteEx2_forInt();
 MainEx2.ExecuteEx2_forString();

 MainEx3.ExecuteEx3();

MainEx4.ExecuteEx4();

//Ex5: aici nu am stiut altfel cum sa initializez
CompareStringProgram compareStringProgram = new CompareStringProgram();
CompareIntProgram compareIntProgram = new CompareIntProgram();
compareStringProgram.CompareMethode("alo", "deltaforce");
compareIntProgram.CompareMethode(15,32);

MainEx6.ExecuteEx6();
MainEx7.ExecuteEx7();

