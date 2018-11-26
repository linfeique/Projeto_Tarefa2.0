using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Senai.Financas.Mvc.Web.Models;
using Senai_Financas_Web_Mvc_Tarde.Interfaces;

namespace Senai_Financas_Web_Mvc_Tarde.Repositorios
{
    public class UsuarioRepositorioSerializacao : IUsuario
    {
        /// <summary>
        /// Lista que armazena todos os usuários do sistema
        /// </summary>
    
        private List<UsuarioModel> UsuarioSalvos {get; set;}

        public UsuarioRepositorioSerializacao()
        {
            // O metódo construtor é uma ótima alternativa para
            // instanciar seus objetos
            
            // Verificando se já existe um arquivo serializado
            if(File.Exists("usuarios.dat")){
                UsuarioSalvos = LerArquivoSerializado();
            }
            else{
                UsuarioSalvos = new List<UsuarioModel>();
            }
        }

        public UsuarioModel BuscarPorEmailESenha(string email, string senha)
        {
            foreach (UsuarioModel usuario in UsuarioSalvos)
            {
                if(usuario.Email == email && usuario.Senha == senha){
                    return usuario;
                }
            }

            return null;
        }

        public UsuarioModel BuscarPorId(int id)
        {
            // Percorre todos os usuários buscando pelo id...
            foreach (UsuarioModel usuario in UsuarioSalvos)
            {
                if(id == usuario.ID){
                    return usuario;
                }
            }

            // Caso não encontre o usuário pelo
            return null;
        }

        public UsuarioModel Cadastrar(UsuarioModel usuario)
        {
            usuario.ID = UsuarioSalvos.Count + 1;
            // Adiciona o usuário na lista
            UsuarioSalvos.Add(usuario);

            // Serializando a lista com todos os usuário cadastrados

            EscreverNoArquivo();

            return usuario;
        }

        private void EscreverNoArquivo()
        {
            // Guarda os bytes da serialização
            MemoryStream memoria = new MemoryStream();

            // Objeto que fará a serialização
            BinaryFormatter serializadora = new BinaryFormatter();

            serializadora.Serialize(memoria, UsuarioSalvos);

            // Pegando os bytes salvos na memória
            byte[] bytes = memoria.ToArray();

            File.WriteAllBytes("usuarios.dat", bytes);
        }

        public UsuarioModel Editar(UsuarioModel usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(int id)
        {
            // Buscando o usuário pelo id
            UsuarioModel usuarioBuscado = BuscarPorId(id);

            // Caso o usuário buscado tenha sido encontrado...
            if(usuarioBuscado != null){
                UsuarioSalvos.Remove(usuarioBuscado);
                
                // Tem-se que atualizar o arquivo com a lista sem o objeto
                EscreverNoArquivo();
            }
        }

        public List<UsuarioModel> Listar(){
            return UsuarioSalvos;
        }

        private List<UsuarioModel> LerArquivoSerializado()
        {
            // Lê os bytes do arquivo
            byte[] bytesSerializacao = File.ReadAllBytes("usuarios.dat");

            // Cria um fluxo de memória com os bytes do arquivo serializado
            MemoryStream memoria = new MemoryStream(bytesSerializacao);

            BinaryFormatter serializador = new BinaryFormatter();

            return (List<UsuarioModel>) serializador.Deserialize(memoria);
        }
    }
}