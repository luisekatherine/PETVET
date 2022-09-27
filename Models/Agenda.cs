using System;
using System.Collections.Generic;
namespace PETVET.Models{
public class Agenda{
    public static List<PreAgendamento> agendamentos;
    static Agenda(){
        agendamentos = new List<PreAgendamento>();
    }
    public void Inserir(PreAgendamento agendamento){
        agendamentos.Add(agendamento);
    }
    public List<PreAgendamento> Listar(){
        foreach (PreAgendamento agendamento in agendamentos);
        return agendamentos;
    }
}
}