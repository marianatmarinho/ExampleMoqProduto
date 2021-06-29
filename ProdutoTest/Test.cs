using Xunit;
using System;
using System.Linq;
using Moq;
using ExampleMoqProduto.Interfaces;
using ExampleMoqProduto.Moldel;

namespace ProdutoTest
{
    public class Test
    {
        Produto produto = new Produto();
        VerificadorPrecoProduto verificador = new VerificadorPrecoProduto();

        [Fact]
        public void DadoUmProdutoComValor35DeveRetornarBarato()
        {
            //Given
            produto.Preco = 35;
            Mock<IVerificadorPrecoProduto> mock = new Mock<IVerificadorPrecoProduto>();
            mock.Setup(m => m.VerificaPrecoProduto(produto)).Returns("Produto Barato!");
            
            //When
            var resultadoEsperado = mock.Object.VerificaPrecoProduto(produto);
            var resultado = verificador.VerificaPrecoProduto(produto);

            //Then
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact]
        public void DadoUmProdutoComValor41DeveRetornarMedio()
        {
            //Given
            produto.Preco = 41;
            Mock<IVerificadorPrecoProduto> mock = new Mock<IVerificadorPrecoProduto>();
            mock.Setup(m => m.VerificaPrecoProduto(produto)).Returns("Produto na média de preço!");
            
            //When
            var resultadoEsperado = mock.Object.VerificaPrecoProduto(produto);
            var resultado = verificador.VerificaPrecoProduto(produto);

            //Then
            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact]
        public void DadoUmProdutoComValor150DeveRetornarCaro()
        {
            //Given
            produto.Preco = 150;
            Mock<IVerificadorPrecoProduto> mock = new Mock<IVerificadorPrecoProduto>();
            mock.Setup(m => m.VerificaPrecoProduto(produto)).Returns("Produto Caro!");
            
            //When
            var resultadoEsperado = mock.Object.VerificaPrecoProduto(produto);
            var resultado = verificador.VerificaPrecoProduto(produto);

            //Then
            Assert.Equal(resultado, resultadoEsperado);
        }
    }
}