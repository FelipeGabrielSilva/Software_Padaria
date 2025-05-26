using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_Padaria.GerarDados;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Resources;

namespace WindowsForm_Padaria.Services
{
    public class Categoria_Service
    {
        private readonly AppDbContext _context;
        private readonly Validacao _valido;

        public Categoria_Service()
        {
            _context = new AppDbContext();
            _valido = new Validacao();
        }

        public void Criar (Categoria c)
        {
            ResultadoValidacao res = _valido.Categoria(c);

            if(!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Categoria.Add(c);
            _context.SaveChanges();

            MessageBox.Show($"A categoria {c.Nome} foi criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Categoria> ListarTodos ()
        {
            List<Categoria> categorias = new List<Categoria>();
                
            categorias = _context.Categoria.ToList();

            return categorias;
        }

        public void Atualizar (Categoria c)
        {
            ResultadoValidacao res = _valido.Categoria(c);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Categoria.Update(c);
            _context.SaveChanges();

            MessageBox.Show($"A categoria {c.Nome} foi atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Deletar (Categoria c)
        {
            ResultadoValidacao res = _valido.Categoria(c);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             _context.Categoria.Remove(c);
             _context.SaveChanges();

            MessageBox.Show($"A categoria {c.Nome} foi deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void PopularBanco()
        {
            if (_context.Categoria.Any())
            {
                return;
            }

            var categorias = CategoriaData.GetCategorias();

            try
            {
                _context.Categoria.AddRange(categorias);
                _context.SaveChanges();

                MessageBox.Show($"Foram adicionadas {categorias.Count} categorias ao banco de dados com sucesso!",
                               "Sucesso",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao popular as categorias: {ex.Message}",
                               "Erro",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
    }
}
