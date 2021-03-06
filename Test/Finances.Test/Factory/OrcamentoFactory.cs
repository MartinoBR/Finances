using Finances.Domain.Entity;

namespace Test.Finances.Factory
{
    public class OrcamentoFactory : BaseFactory<Orcamento>
    {
        private OrcamentoFactory()
        {            
        }

        public static OrcamentoFactory Get()
        {
            return new OrcamentoFactory();
        }

        public static OrcamentoFactory GetValid()
        {
            var factory = Get();
            factory.PopulateValid();

            return factory;
        }

        public OrcamentoFactory WithID(int id)
        {
            Instance.ID = id;

            return this;
        }

        public OrcamentoFactory WithValor(decimal valor)
        {
            Instance.Valor = valor;

            return this;
        }

        public OrcamentoFactory WithVigencia(Vigencia vigencia)
        {
            Instance.Vigencia = vigencia;

            return this;
        }

        protected override void PopulateValid()
        {
            Instance.ID = 1;
            Instance.Vigencia = VigenciaFactory.GetValid().Build();
            Instance.Valor = 1000;
        }
    }
}