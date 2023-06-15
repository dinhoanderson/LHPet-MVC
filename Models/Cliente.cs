namespace LHPet.Models;

public class Cliente
{
    // No trecho de código a seguir são criadaos os atributos de Cliente e seus getters e setters correspondentes.//

    public int ID { get; set; }
    public string? Nome {get ;set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Paciente { get; set; }

    // Nesse trecho de código, é criado o construtor do model Cliente e determinado quais parâmetros são necessários na criação das instâncias.//

    
    public Cliente(int id, string nome, string cpf, string email, string paciente)
    {
        this.ID = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }
}