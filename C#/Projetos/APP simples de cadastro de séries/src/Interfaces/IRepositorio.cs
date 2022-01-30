

namespace APP_simples_de_cadastro_de_séries
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornaPorId (int id);

         void Insere(T entidade);

         void Exclui(int id);

         void Atualiza(int id, T entidade);

         int ProximoId();
    }
}