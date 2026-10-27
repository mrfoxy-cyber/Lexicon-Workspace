using interfaces;

Program1 program1 = new Program1();
Program2 program2 = new Program2();

program1.Run();
program2.Go();

IProgram Iprogram1 = new Program1();
IProgram Iprogram2 = new Program2();

Iprogram1.Start();
Iprogram2.Start();

IStop Istop = new Program1();

Istop.Stop();

int x = Istop.Run();
Iprogram1.Run();
program1.Run();
