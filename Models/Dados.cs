using System;
namespace PETVET.Models{
public static class Dados{
    public static Agenda AgendaAtual{get;set;}
    static Dados()
    {
        AgendaAtual = new Agenda();

    }
}
}