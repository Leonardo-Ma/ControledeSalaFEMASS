﻿using ControledeSalaFEMASS.Domain.Entities;

namespace ControledeSalaFEMASS.Domain.Repositories;
public interface ITurmaRepository
{
    Task<IList<Turma>> GetAll();
    Task<Turma?> GetById(long turmaId);
    Task<IList<AlocacaoSala>> GetAlocacoesByTurma(long turmaId);
    Task<bool> ExistsTurmaWithCodigo(int codigoTurma);
    Task<bool> ExistsTurmaAgrupada();
    Task<IList<Turma>> GetTurmasAgrupadas();
    Task<IList<AlocacaoSala>> GetAlocacoesByDay(DayOfWeek dayOfWeek);
    Task Add(Turma turma);
    Task AddRange(List<Turma> turmas);
    void Update(Turma turma);
    void LimparSemestre();
}