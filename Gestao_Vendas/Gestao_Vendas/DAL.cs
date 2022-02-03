using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestao_Vendas
{
    class DAL
    {
        public bool certo = false;
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter da = null;
        DataTable dt = null;
        DataSet ds = null;

        //======== Login
        #region Login
        public DataTable Login(model.mUsuario user)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();

            try
            {
                
                con.Open();
                cmd.CommandText = "select * from usuario where usuario = @user and senha = @senha and estado = 1";
                cmd.Parameters.AddWithValue("@user", user.usuario);
                cmd.Parameters.AddWithValue("@senha", user.senha);
                da.SelectCommand = cmd;
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                return dt;

            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        // Ultimo login

        public void UltimoLogin(int id)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.CommandText = "UPDATE usuario SET ultimo_login = current_timestamp() WHERE id = "+id+" ";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        // Produto

        #region Produto
        public DataTable MostrarTabelaProduto()
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();
            try
            {

                con.Open();
                cmd.CommandText = @"select
tbp.id as 'ID',
tbp.nome as 'Produto',
tbp.descricao as 'Descricao',
tbp.quantidade as 'Quantidade',
tbp.preco as 'Preco',
tbu.usuario as 'Cadastrado por ',
tbc.nome as 'Categoria'
  from
produto as tbp
  inner JOIN
  usuario as tbu on tbu.id = tbp.usuario_id
  inner JOIN categoria as tbc on tbc.id = tbp.categoria_id
; ";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //para preencher o combobox categoria
        public DataTable MostrarTabelaCategoria()
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();
            try
            {

                con.Open();
                cmd.CommandText = "select * from categoria";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //===== Adicionar um novo produto

        public void CadastrarProduto(model.mProduto prod)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {

                con.Open();
                cmd.CommandText = "INSERT INTO produto VALUES (NULL, @nome, @descricao, @preco, @quantidade, current_timestamp(), NULL, @categoria, @user)";
                cmd.Parameters.AddWithValue("@nome", prod.nome);
                cmd.Parameters.AddWithValue("@descricao", prod.descricao);
                cmd.Parameters.AddWithValue("@preco",prod.preco);
                cmd.Parameters.AddWithValue("@quantidade",prod.quantidade);
                cmd.Parameters.AddWithValue("@categoria",prod.categoria);
                cmd.Parameters.AddWithValue("@user", prod.usuario);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Eliminar Produto
        public void EliminarProduto(model.mProduto prod)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {

                con.Open();
                cmd.CommandText = "delete from produto where id = @id";
                cmd.Parameters.AddWithValue("@id", prod.idproduto);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //alterar dados

        public DataTable EditarProduto(model.mProduto prod)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();

            try
            {

                con.Open();
                cmd.CommandText = "select * from produto where id = @id ";
                cmd.Parameters.AddWithValue("@id", prod.idproduto);
                da.SelectCommand = cmd;
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Alterar os valores

        public void alterProduto(model.mProduto prod)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {

                con.Open();
                cmd.CommandText = "UPDATE produto SET nome = @nome, descricao = @desc, preco = @preco, quantidade = @qtd, categoria_id = @cat WHERE id =@id ";
                cmd.Parameters.AddWithValue("@id", prod.idproduto);
                cmd.Parameters.AddWithValue("@nome", prod.nome);
                cmd.Parameters.AddWithValue("@desc", prod.descricao);
                cmd.Parameters.AddWithValue("@preco", prod.preco);
                cmd.Parameters.AddWithValue("@qtd", prod.quantidade);
                cmd.Parameters.AddWithValue("@cat", prod.categoria);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        #endregion

        //==== Categoria
        #region Categoria
        public void CadastrarCategoria(model.mCategoria cat)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {

                con.Open();
                cmd.CommandText = "insert into categoria values(null,@nome,@descricao)";
                cmd.Parameters.AddWithValue("@nome", cat.nome);
                cmd.Parameters.AddWithValue("@descricao", cat.descricao);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Pesquisar categoria
        public DataTable PesquisarCategoria(model.mCategoria cat)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();

            try
            {

                con.Open();
                cmd.CommandText = "select * from categoria where id = @id ";
                cmd.Parameters.AddWithValue("@id", cat.idcategoria);
                da.SelectCommand = cmd;
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Eliminar Categoria

        public void EliminarCategoria(model.mCategoria cat)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {

                con.Open();
                cmd.CommandText = "delete from categoria where id = @id";
                cmd.Parameters.AddWithValue("@id", cat.idcategoria);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Alterar dados da categoria

        public void alterarCategoria(model.mCategoria cat)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {

                con.Open();
                cmd.CommandText = "update categoria set nome = @nome, descricao = @desc where id = @id";
                cmd.Parameters.AddWithValue("@id", cat.idcategoria);
                cmd.Parameters.AddWithValue("@nome",cat.nome);
                cmd.Parameters.AddWithValue("@desc", cat.descricao);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        //Clientes

        #region Clientes
        public DataTable MostrarTabelaCliente()
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();
            try
            {

                con.Open();
                cmd.CommandText = "select * from cliente";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Inserir cliente

        public void CadastrarCliente(model.mCliente cli)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {

                con.Open();
                cmd.CommandText = "INSERT INTO cliente values (null,@nome,@telefone,@morada)";
                cmd.Parameters.AddWithValue("@nome", cli.nome);
                cmd.Parameters.AddWithValue("@telefone", cli.telefone);
                cmd.Parameters.AddWithValue("@morada", cli.morada);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Eliminar Cliente
        public void EliminarCliente(model.mCliente cli)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.CommandText = "delete from cliente where id = @id";
                cmd.Parameters.AddWithValue("@id", cli.idcliente);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Pegar ID

        public DataTable EditarCliente(model.mCliente cli)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();

            try
            {

                con.Open();
                cmd.CommandText = "select * from cliente where id = @id ";
                cmd.Parameters.AddWithValue("@id", cli.idcliente);
                da.SelectCommand = cmd;
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Editar dados do cliente

        public void alterCliente(model.mCliente cli)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.CommandText = "UPDATE cliente SET nome = @nome, telefone = @tel, morada = @morada WHERE id =@id ";
                cmd.Parameters.AddWithValue("@id", cli.idcliente);
                cmd.Parameters.AddWithValue("@nome", cli.nome);
                cmd.Parameters.AddWithValue("@tel", cli.telefone);
                cmd.Parameters.AddWithValue("@morada", cli.morada);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        //Venda
        #region Venda
        public DataTable MostrarTabelaVenda()
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();
            try
            {

                con.Open();
                cmd.CommandText = @"select 
tbv.id as 'ID', 
tbv.total_venda as 'Valor Total',
tbv.valor_pago as 'Valor Pago',
tbv.troco as 'Troco',
tbv.desconto as 'Desconto',
tbv.iva as 'IVA',
tbc.nome as 'Cliente',
tbu.usuario as 'Usuario'
  from venda as tbv
inner join cliente as tbc on tbc.id = tbv.cliente_id
inner join usuario as tbu on tbu.id = tbv.usuario_id order by id";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public DataSet MostrarProduto()
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            ds = new DataSet();
            try
            {

                con.Open();
                cmd.CommandText = "select * from produto";
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Vai retornar o produto selecionado isso nos vai ajudar a obter todas informações desse produto

        public DataTable RetornarProdutoSelecionado(string nome)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();
            try
            {

                con.Open();
                cmd.CommandText = "select * from produto where nome = '"+nome+"' ";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet MostrarClien()
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            ds = new DataSet();
            try
            {

                con.Open();
                cmd.CommandText = "select * from cliente";
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Eliminar Registo Venda
        public void EliminarRegistoVenda(model.mVenda venda)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.CommandText = "delete from venda where id = @id";
                cmd.Parameters.AddWithValue("@id", venda.idvenda);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Vender

        public void Vender(model.mVenda venda)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {

                con.Open();
                cmd.CommandText = "insert into venda values (NULL, @totvenda, @valPago, @troco, @desconto, @iva,current_timestamp(), @cli, @user)";
                cmd.Parameters.AddWithValue("@totvenda", venda.totalvenda);
                cmd.Parameters.AddWithValue("@valPago", venda.valorpago);
                cmd.Parameters.AddWithValue("@troco", venda.troco);
                cmd.Parameters.AddWithValue("@desconto", venda.desconto);
                cmd.Parameters.AddWithValue("@iva", venda.iva);
                cmd.Parameters.AddWithValue("@cli", venda.cliente);
                cmd.Parameters.AddWithValue("@user", venda.usuario);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Actualizar a quantidade do produto vendido;

        public void actualizarQtdProduto(model.mProduto prod)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {

                con.Open();
                cmd.CommandText = "UPDATE produto SET  quantidade = @qtd WHERE id = "+model.Global.pegarIdProdutoSelecionado+" ";
                cmd.Parameters.AddWithValue("@qtd", prod.quantidade);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        //Usuarios
        #region Usuarios
        public DataTable MostrarTabelaUsuarios()
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();
            try
            {

                con.Open();
                cmd.CommandText = "select id, nome,usuario,perfil,estado from usuario";
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        // Adicionar um usuario

        public void CadastrarUsuario(model.mUsuario user)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {

                con.Open();
                cmd.CommandText = "INSERT INTO usuario VALUES (NULL, @nome, @usuario, @senha, @perfil, @estado, current_timestamp(), NULL)";
                cmd.Parameters.AddWithValue("@nome", user.nome);
                cmd.Parameters.AddWithValue("@usuario", user.usuario);
                cmd.Parameters.AddWithValue("@senha", user.senha);
                cmd.Parameters.AddWithValue("@perfil", user.perfil);
                cmd.Parameters.AddWithValue("@estado", user.estado);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Remover um usuário

        public void EliminarUsuario(model.mUsuario user)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.CommandText = "delete from usuario where id = @id";
                cmd.Parameters.AddWithValue("@id", user.idusuario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Just to take the id
        public DataTable PesquisarUsuario(model.mUsuario user)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;
            da = new MySqlDataAdapter();
            dt = new DataTable();

            try
            {

                con.Open();
                cmd.CommandText = "select * from usuario where id = @id ";
                cmd.Parameters.AddWithValue("@id", user.idusuario);
                da.SelectCommand = cmd;
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Alterar os valores

        public void alterUsuario(model.mUsuario user)
        {
            con = new MySqlConnection(conexao.stringcon);
            cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.CommandText = "UPDATE usuario SET nome = @nome, usuario = @user, senha = @senha, perfil = @perfil, estado = @estado, ultimo_login = current_timestamp() WHERE id = @id ";
                cmd.Parameters.AddWithValue("@id", user.idusuario);
                cmd.Parameters.AddWithValue("@nome", user.nome);
                cmd.Parameters.AddWithValue("@user", user.usuario);
                cmd.Parameters.AddWithValue("@senha", user.senha);
                cmd.Parameters.AddWithValue("@perfil", user.perfil);
                cmd.Parameters.AddWithValue("@estado", user.estado);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

    }
}
