-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 03-Fev-2022 às 13:29
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `db_gestaovenda`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoria`
--

CREATE TABLE `categoria` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `descricao` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `categoria`
--

INSERT INTO `categoria` (`id`, `nome`, `descricao`) VALUES
(1, 'Frescos', 'Lagostas'),
(2, 'Cereais', 'os melhores para crianças'),
(3, 'Legumes', 'Legumes Nacionais'),
(4, 'Frutas', ''),
(5, 'Bebidas', ''),
(7, 'Electrodomésticos', 'Produtos de qualidade');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `telefone` varchar(12) NOT NULL,
  `morada` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id`, `nome`, `telefone`, `morada`) VALUES
(1, 'António Mendes Silva', '928-328-398', 'viana'),
(2, 'António Joõa', '917-218-291', 'camacupa'),
(5, 'ddaj', '928-389-283', 'viana'),
(9, 'Manuel Edson', '918-291-821', 'Benguela - Lobito'),
(11, '', '', 'mk');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `descricao` varchar(80) NOT NULL,
  `preco` decimal(10,2) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `data_criacao` datetime NOT NULL DEFAULT current_timestamp(),
  `data_alteracao` datetime DEFAULT NULL,
  `categoria_id` int(11) NOT NULL,
  `usuario_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`id`, `nome`, `descricao`, `preco`, `quantidade`, `data_criacao`, `data_alteracao`, `categoria_id`, `usuario_id`) VALUES
(1, 'Arroz Tio João', 'Arroz castanho', '300.00', 10, '2022-01-20 17:11:41', NULL, 2, 1),
(2, 'Massa maria', 'granda massa', '150.00', 100, '2022-01-20 17:38:41', NULL, 2, 1),
(3, 'Salsa', 'para salada', '120.00', 3, '2022-01-20 17:43:28', NULL, 3, 1),
(4, 'Frango', 'para um bom franguité', '0.00', 9, '2022-01-20 17:47:05', NULL, 1, 1),
(7, 'Banana Pão', 'banana de Malanje', '100.00', 3, '2022-01-20 18:52:20', NULL, 3, 1),
(8, 'agua perla', 'garrafa pequena', '100.00', 4, '2022-01-20 22:39:28', NULL, 1, 3),
(25, 'peixe Carapau', '', '200.00', 2, '2022-01-21 06:16:19', NULL, 2, 1),
(26, 'peixe lambula', 'grande sangrinha', '100.00', 3, '2022-01-21 06:21:15', NULL, 1, 3),
(27, 'Pera', 'Fruta saborosa', '200.00', 3, '2022-01-26 20:07:51', NULL, 4, 2),
(29, 'Bolacha Maria', 'Pura sangrinha', '220.00', 1, '2022-01-26 21:02:20', NULL, 2, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `usuario` varchar(30) NOT NULL,
  `senha` varchar(180) NOT NULL,
  `perfil` varchar(30) NOT NULL DEFAULT 'Padrao',
  `estado` int(1) NOT NULL DEFAULT 0,
  `data_criacao` datetime NOT NULL DEFAULT current_timestamp(),
  `ultimo_login` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`id`, `nome`, `usuario`, `senha`, `perfil`, `estado`, `data_criacao`, `ultimo_login`) VALUES
(1, 'Rodrigo Isaac', 'Atalaia', '4A7D1ED414474E4033AC29CCB8653D9B', 'Admin', 1, '2022-01-19 14:55:51', '2022-02-03 11:44:41'),
(2, 'Joana Rafaela', 'Catimba', '26D7C2EF968F999911DF95F814E83F8', 'Padrao', 0, '2022-01-19 22:06:43', '2022-01-27 21:32:46'),
(3, 'Pedro Abraão', 'Kippanda', 'lordkipanda', 'Admin', 0, '2022-01-20 21:16:29', NULL),
(8, 'Tomas Vunge', 'Tomas', 'vunge', 'Padrao', 1, '2022-01-21 09:21:45', NULL),
(12, 'André Miguel', 'Milito', '72B32BF297A228A7573123EFEF7C41', 'Padrao', 0, '2022-01-27 21:06:48', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE `venda` (
  `id` int(11) NOT NULL,
  `total_venda` decimal(10,2) NOT NULL,
  `valor_pago` decimal(10,2) NOT NULL,
  `troco` decimal(10,2) NOT NULL,
  `desconto` decimal(10,2) NOT NULL,
  `iva` decimal(10,2) NOT NULL,
  `data_venda` datetime NOT NULL DEFAULT current_timestamp(),
  `cliente_id` int(11) NOT NULL,
  `usuario_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `venda`
--

INSERT INTO `venda` (`id`, `total_venda`, `valor_pago`, `troco`, `desconto`, `iva`, `data_venda`, `cliente_id`, `usuario_id`) VALUES
(1, '200.00', '300.00', '100.00', '0.00', '0.00', '2022-01-20 22:14:16', 5, 2),
(3, '200.00', '300.00', '100.00', '100.00', '0.14', '2022-02-02 11:07:21', 2, 2),
(4, '3000.00', '2500.00', '500.00', '0.00', '0.00', '2022-02-02 19:59:27', 1, 12),
(6, '674.00', '4000.00', '3326.00', '10.00', '0.14', '2022-02-02 20:31:23', 1, 1),
(7, '104.00', '1000.00', '896.00', '10.00', '0.14', '2022-02-02 20:55:04', 1, 1),
(8, '96.80', '5000.00', '4903.20', '3.20', '0.00', '2022-02-02 21:02:16', 1, 1),
(9, '547.20', '2500.00', '1952.80', '0.00', '0.14', '2022-02-02 22:22:22', 1, 1),
(10, '273.60', '600.00', '326.40', '0.00', '0.14', '2022-02-02 22:23:06', 1, 1),
(11, '501.60', '600.00', '98.40', '0.00', '0.14', '2022-02-03 05:13:24', 11, 1),
(12, '380.00', '4000.00', '3620.00', '20.00', '0.14', '2022-02-03 11:45:55', 11, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda_item`
--

CREATE TABLE `venda_item` (
  `venda_id` int(11) NOT NULL,
  `produto_id` int(11) NOT NULL,
  `quantidade` int(11) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `desconto` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `venda_item`
--

INSERT INTO `venda_item` (`venda_id`, `produto_id`, `quantidade`, `total`, `desconto`) VALUES
(1, 1, 1, '200.00', NULL);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nome` (`nome`),
  ADD KEY `usuario_id` (`usuario_id`),
  ADD KEY `categoria_id` (`categoria_id`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `usuario` (`usuario`);

--
-- Índices para tabela `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`id`),
  ADD KEY `cliente_id` (`cliente_id`),
  ADD KEY `usuario_id` (`usuario_id`);

--
-- Índices para tabela `venda_item`
--
ALTER TABLE `venda_item`
  ADD KEY `venda_id` (`venda_id`),
  ADD KEY `produto_id` (`produto_id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `categoria`
--
ALTER TABLE `categoria`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `venda`
--
ALTER TABLE `venda`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `produto_ibfk_1` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`id`),
  ADD CONSTRAINT `produto_ibfk_2` FOREIGN KEY (`categoria_id`) REFERENCES `categoria` (`id`);

--
-- Limitadores para a tabela `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `venda_ibfk_1` FOREIGN KEY (`cliente_id`) REFERENCES `cliente` (`id`),
  ADD CONSTRAINT `venda_ibfk_2` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`id`);

--
-- Limitadores para a tabela `venda_item`
--
ALTER TABLE `venda_item`
  ADD CONSTRAINT `venda_item_ibfk_1` FOREIGN KEY (`venda_id`) REFERENCES `venda` (`id`),
  ADD CONSTRAINT `venda_item_ibfk_2` FOREIGN KEY (`produto_id`) REFERENCES `produto` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
