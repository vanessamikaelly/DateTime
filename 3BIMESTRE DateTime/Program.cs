using System;

class URI
{
    static void Main(string[] args)
    {

        Console.WriteLine("Informe a data de nascimento: ");
        DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine()); //serve tambem pra verificar se é sabado ou domingo para não poder agendar
        Console.WriteLine(dataNascimento.DayOfWeek);




        DateTime data1 = new DateTime(2023,07,24);  //d4
        DateTime data2 = new DateTime(2006, 02, 01, 15, 50, 0);

        Console.WriteLine(data1);
        Console.WriteLine(data2);
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.UtcNow);  //pega o ponto de referencia onde todos os horarios tem como referencia
        Console.WriteLine(DateTime.Today); //aqui só pega a data, as hpras ficam tudo 00 00 00



        Console.WriteLine(data1.Month); // pega o mes
        Console.WriteLine(DateTime.Today); // pega o dia

        Console.WriteLine(data1.DayOfWeek); // pega o dia da semana
        Console.WriteLine(DateTime.Today); // pega o dia do ano

        DateTime d3 = data1.AddDays(5); //pode ser usado pra agendar data // pode adicionar negativo tambem 
        Console.WriteLine(d3);

        DateTime d4 = data2.AddYears(2);
        Console.WriteLine(d4);


        TimeSpan a = data1.Subtract(data2); //intervalos entre datas
        Console.WriteLine(a.Days);






        TimeSpan b = new TimeSpan(6350, 00, 00, 00);

        DateTime novadata = DateTime.Now.Subtract(a);

        Console.WriteLine(novadata); //aqui eu ja sei a quanto tempo (dias eu tenho de vida, ou o boleto venceu)







        //COMPARAÇÃO DE DUAS DATAS

        DateTime dat1 = new DateTime(2023, 07, 22);
        DateTime dat2 = new DateTime(2023, 07, 24);


        // 0 - datas iguais 
        // -1 a primeira data é anterior a segunda 
        // 1 - a primeira data é prosterior a segunda
        int retornoComDatas = DateTime.Compare(dat1, dat2); // de preferencia usar uma variavel com valor 

        Console.WriteLine(DateTime.Compare(dat1, dat2)); //o compare é um metodo estatico entaoo nao é acessadi atraves de objeto, por isso tem que chamar o metodo

        //exemplo de funcionadidade, informar um evento ocorreu, qual data é mais recende, comparar data

      






        Console.ReadKey();  
    }
}


