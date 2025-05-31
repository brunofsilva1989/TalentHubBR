using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Crypto.Digests;
using System.Reflection.Metadata;
using System.Text;
using TalentHub.BLL.Interfaces;
using TalentHub.DAL;
using TalentHub.Domain.Entities;

namespace TalentHub.BLL.Services
{
    public class BoRelatorioService : IRelatorioService
    {
        #region Propriedades Privadas
        private readonly TalentHubContext _context;
        #endregion

        #region Construtores
        public BoRelatorioService(TalentHubContext context)
        {
            _context = context;
        }
        #endregion

        #region Métodos
        public void GerarRelatorioCandidatoIndividual(int id, string filePath)
        {
            var candidato = _context.Candidatos.Find(id);

            try
            {
                if (candidato == null)
                    throw new KeyNotFoundException("Candidato não encontrado.");

                iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                doc.Open();

                // Título formatado
                var titulo = new Paragraph($"Relatório do Candidato: {candidato.Nome}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20f;
                doc.Add(titulo);

                // Tabela formatada
                PdfPTable tabela = new PdfPTable(2);
                tabela.WidthPercentage = 80;
                tabela.SetWidths(new float[] { 2f, 5f });

                tabela.AddCell(Celula("Campo", true));
                tabela.AddCell(Celula("Valor", true));

                tabela.AddCell(Celula("Nome"));
                tabela.AddCell(Celula(candidato.Nome));

                tabela.AddCell(Celula("Email"));
                tabela.AddCell(Celula(candidato.Email));

                tabela.AddCell(Celula("Telefone"));
                tabela.AddCell(Celula(candidato.Telefone));

                tabela.AddCell(Celula("Data de Nascimento"));
                tabela.AddCell(Celula(candidato.DataNascimento.ToString("dd/MM/yyyy")));

                tabela.AddCell(Celula("Status"));
                tabela.AddCell(Celula(candidato.Status.ToString()));

                doc.Add(tabela);

                // Rodapé com data
                Paragraph rodape = new Paragraph($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9));
                rodape.SpacingBefore = 20f;
                rodape.Alignment = Element.ALIGN_RIGHT;
                doc.Add(rodape);

                doc.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao gerar relatório do candidato: {ex.Message}");
            }
        }                

        public void GerarRelatorioCandidatosGeral(string filePath)
        {
            var candidatos = _context.Candidatos.ToList();

            try
            {
                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                PdfWriter.GetInstance(doc, new System.IO.FileStream(filePath, System.IO.FileMode.Create));
                doc.Open();

                // Título formatado
                var titulo = new Paragraph($"Relatório do Candidatos:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20f;
                doc.Add(titulo);               

                foreach (var c in candidatos)
                {   
                    PdfPTable tabela = new PdfPTable(2); // 2 colunas
                    tabela.WidthPercentage = 80; // Tabela ocupa 100% da largura da página
                    tabela.SetWidths(new float[] { 3f, 7f }); // Define proporção das colunas
                    tabela.SpacingBefore = 10f; // Espaço antes da tabela
                    tabela.SpacingAfter = 20f;

                    tabela.AddCell(Celula("Nome", true));
                    tabela.AddCell(c.Nome);

                    tabela.AddCell(Celula("Email", true));
                    tabela.AddCell(c.Email);

                    tabela.AddCell(Celula("Telefone", true));
                    tabela.AddCell(c.Telefone);

                    tabela.AddCell(Celula("DataNascimento", true));
                    tabela.AddCell(c.DataNascimento.ToShortDateString());

                    tabela.AddCell(Celula("Status", true));
                    tabela.AddCell(c.Status.ToString());
                    
                    doc.Add(tabela);
                }

                
                // Rodapé com data
                Paragraph rodape = new Paragraph($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9));
                rodape.SpacingBefore = 20f;
                rodape.Alignment = Element.ALIGN_RIGHT;
                doc.Add(rodape);

                doc.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao gerar relatório geral dos candidatos: {ex.Message}");
            }
        }

        public void GerarRelatorioEmpresasGeral(string filePath)
        {
            var empresa = _context.Empresas.ToList();

            try
            {
                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                PdfWriter.GetInstance(doc, new System.IO.FileStream(filePath, System.IO.FileMode.Create));
                doc.Open();

                // Título formatado
                var titulo = new Paragraph($"Relatório do Empresa:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20f;
                doc.Add(titulo);

                foreach (var e in empresa)
                {
                    PdfPTable tabela = new PdfPTable(2); 
                    tabela.WidthPercentage = 80; 
                    tabela.SetWidths(new float[] { 3f, 7f }); 
                    tabela.SpacingBefore = 10f; 
                    tabela.SpacingAfter = 20f;

                    tabela.AddCell(Celula("Nome", true));
                    tabela.AddCell(e.Nome);

                    tabela.AddCell(Celula("Email", true));
                    tabela.AddCell(e.Email);

                    tabela.AddCell(Celula("Contato", true));
                    tabela.AddCell(e.Contato);
                    
                    doc.Add(tabela);
                }

                // Rodapé com data
                Paragraph rodape = new Paragraph($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9));
                rodape.SpacingBefore = 20f;
                rodape.Alignment = Element.ALIGN_RIGHT;
                doc.Add(rodape);

                doc.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao gerar relatório geral dos candidatos: {ex.Message}");
            }
        }

        public void GerarRelatorioEmpresasIndividual(int id, string filePath)
        {
            var empresa = _context.Empresas.Find(id);

            try
            {
                if (empresa == null)
                    throw new KeyNotFoundException("Candidato não encontrado.");

                iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                doc.Open();

                // Título formatado
                var titulo = new Paragraph($"Relatório do Candidato: {empresa.Nome}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20f;
                doc.Add(titulo);

                // Tabela formatada
                PdfPTable tabela = new PdfPTable(2);
                tabela.WidthPercentage = 80;
                tabela.SetWidths(new float[] { 2f, 5f });

                tabela.AddCell(Celula("Campo", true));
                tabela.AddCell(Celula("Valor", true));

                tabela.AddCell(Celula("Nome"));
                tabela.AddCell(Celula(empresa.Nome));

                tabela.AddCell(Celula("Email"));
                tabela.AddCell(Celula(empresa.Email));

                tabela.AddCell(Celula("Contato"));
                tabela.AddCell(Celula(empresa.Contato));

                doc.Add(tabela);

                // Rodapé com data
                Paragraph rodape = new Paragraph($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9));
                rodape.SpacingBefore = 20f;
                rodape.Alignment = Element.ALIGN_RIGHT;
                doc.Add(rodape);

                doc.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao gerar relatório do candidato: {ex.Message}");
            }
        }

        public void GerarRelatorioFeedbackIndividual(int idFeedBack, int idCandidato, string filePath)
        {
            var feedback = _context.Feedbacks.Find(idFeedBack);

            try
            {
                if (feedback == null)
                    throw new KeyNotFoundException("Feedback não encontrado.");

                var candidato = _context.Candidatos.Find(idCandidato);
                if (candidato == null)
                    throw new KeyNotFoundException("Candidato não encontrado.");

                iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                doc.Open();

                // Título formatado
                var titulo = new Paragraph($"Relatório do Feedback pelo Candidato: {candidato.Nome}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20f;
                doc.Add(titulo);

                // Tabela formatada
                PdfPTable tabela = new PdfPTable(2);
                tabela.WidthPercentage = 80;
                tabela.SetWidths(new float[] { 2f, 5f });

                tabela.AddCell(Celula("Campo", true));
                tabela.AddCell(Celula("Valor", true));

                tabela.AddCell(Celula("Nome"));
                tabela.AddCell(Celula(candidato.Nome));

                tabela.AddCell(Celula("Comentário"));
                tabela.AddCell(Celula(feedback.Comentario));

                tabela.AddCell(Celula("Data do Feedback"));
                tabela.AddCell(Celula(feedback.DataFeedback.ToString("dd/MM/yyyy")));

                doc.Add(tabela);

                // Rodapé com data
                Paragraph rodape = new Paragraph($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9));
                rodape.SpacingBefore = 20f;
                rodape.Alignment = Element.ALIGN_RIGHT;
                doc.Add(rodape);

                doc.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao gerar relatório do feedback: {ex.Message}");
            }
        }
        
        public void GerarRelatorioFeedbacksGeral(string filePath)
        {
            var feedbacks = _context.Feedbacks.ToList();

            try
            {
                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                PdfWriter.GetInstance(doc, new System.IO.FileStream(filePath, System.IO.FileMode.Create));
                doc.Open();

                // Título formatado
                var titulo = new Paragraph($"Relatório do Empresa:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20f;
                doc.Add(titulo);

                foreach (var f in feedbacks)
                {
                    PdfPTable tabela = new PdfPTable(2);
                    tabela.WidthPercentage = 80;
                    tabela.SetWidths(new float[] { 3f, 7f });
                    tabela.SpacingBefore = 10f;
                    tabela.SpacingAfter = 20f;

                    tabela.AddCell(Celula("Comentarios", true));
                    tabela.AddCell(f.Comentario);

                    tabela.AddCell(Celula("DataFeedback", true));
                    tabela.AddCell(f.DataFeedback.ToShortDateString());

                    doc.Add(tabela);
                }

                // Rodapé com data
                Paragraph rodape = new Paragraph($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9));
                rodape.SpacingBefore = 20f;
                rodape.Alignment = Element.ALIGN_RIGHT;
                doc.Add(rodape);

                doc.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao gerar relatório geral dos Feedbacks: {ex.Message}");
            }
        }

        public void GerarRelatorioVagaIndividual(int id, string filePath)
        {
            throw new NotImplementedException();
        }

        public void GerarRelatorioVagasGeral(string filePath)
        {
            var vagas = _context.Vagas.ToList();

            try
            {
                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                PdfWriter.GetInstance(doc, new System.IO.FileStream(filePath, System.IO.FileMode.Create));
                doc.Open();

                // Título formatado
                var titulo = new Paragraph($"Relatório do Empresa:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20f;
                doc.Add(titulo);

                foreach (var v in vagas)
                {
                    PdfPTable tabela = new PdfPTable(2);
                    tabela.WidthPercentage = 80;
                    tabela.SetWidths(new float[] { 3f, 7f });
                    tabela.SpacingBefore = 10f;
                    tabela.SpacingAfter = 20f;

                    tabela.AddCell(Celula("Descricao", true));
                    tabela.AddCell(v.Descricao);

                    tabela.AddCell(Celula("Cargo", true));
                    tabela.AddCell(v.Cargo);

                    tabela.AddCell(Celula("Salario", true));
                    tabela.AddCell(v.Salario.ToString());
                   
                    tabela.AddCell(Celula("DataAbertura", true));
                    tabela.AddCell(v.DataAbertura.ToString("dd/MM/yyyy"));

                    tabela.AddCell(Celula("DataExpiracao", true));
                    tabela.AddCell(v.DataExpiracao.ToString("dd/MM/yyyy"));

                    doc.Add(tabela);
                }

                // Rodapé com data
                Paragraph rodape = new Paragraph($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9));
                rodape.SpacingBefore = 20f;
                rodape.Alignment = Element.ALIGN_RIGHT;
                doc.Add(rodape);

                doc.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao gerar relatório geral das vagas: {ex.Message}");
            }
        }

        /// <summary>
        /// Função auxiliar para criar uma célula formatada para a tabela do PDF.
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="cabecalho"></param>
        /// <returns></returns>
        private PdfPCell Celula(string texto, bool cabecalho = false)
        {
            var fonte = cabecalho
                ? FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE)
                : FontFactory.GetFont(FontFactory.HELVETICA, 11);

            var cell = new PdfPCell(new Phrase(texto, fonte))
            {
                Padding = 8,
                BorderWidth = 1,
                HorizontalAlignment = Element.ALIGN_LEFT,
                BackgroundColor = cabecalho ? BaseColor.GRAY : BaseColor.WHITE
            };

            return cell;
        }
        #endregion
    }
}
        
    

