using FluentAssertions;
using HelperStockBeta.Domain.Entities;

namespace HelperStockBeta.Domain.Test
{
    #region Casos de testes positivos
    public class ProductUnitTestBase
    {
        #region Casos de testes positivos

        [Fact(DisplayName = "Product name is not null")]
        public void CreateProduct_WithValidParameters_ResultValid()
        {
            Action action = () => new Product(1, "Produto", "Descrição", 160, 10, "google.com.br");

            action.Should().NotThrow<HelperStockBeta.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Product no present id parameter")]
        public void CreateProduct_IdParameterless_ResultValid()
        {
            Action action = () => new Product("Produto", "Descrição", 160, 10, "google.com.br");

            action.Should().NotThrow<HelperStockBeta.Domain.Validation.DomainExceptionValidation>();
        }

        #endregion

        #region Casos de testes negativos

        [Fact(DisplayName = "Id negative exception.")]
        public void CreateProduct_NegativeParameterId_ResultException()
        {
            Action action = () => new Product(-1, "Produto", "Descricao", 160, 10, "google.com.br");
            action
                .Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid negative values for id.");
        }

        #region Name
        [Fact(DisplayName = "Name in product null.")]
        public void CreateProduct_NameParameterNull_ResultException()
        {
            Action action = () => new Product(1, "", "Descrição", 160, 10, "google.com.br");
            action
                .Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Name in product invalid.")]
        public void CreateCategory_NameParameterShort_ResultException()
        {
            Action action = () => new Product(1, "Li", "Descrição", 160, 10, "google.com.br");

            action
                .Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid short names, minimum 3 characteres.");
        }
        #endregion

        #region Description
        [Fact(DisplayName = "Description in product is null.")]
        public void CreateProduct_DescriptionParameterNull_ResultException()
        {
            Action action = () => new Product(1, "Produto", "", 160, 10, "google.com.br");

            action
                .Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, description is required.");
        }

        [Fact(DisplayName = "Description in product is invalid.")]
        public void CreateProduct_DescriptionParameterShort_ResultException()
        {
            Action action = () => new Product(1, "Produto", "des", 160, 10, "google.com.br");
            action  
                .Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid short descriptions, minimum 5 characters.");
        }
        #endregion

        #region Price
        [Fact(DisplayName = "Price in product is null.")]
        public void CreateProduct_NegativeParameterPrice_ResultException()
        {
            Action action = () => new Product(1, "Produto", "Descricao", -160, 10, "google.com.br");

            action
                .Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid negative values for price.");
        }
        #endregion

        #region Stock
        [Fact(DisplayName = "Stock negative exception.")]
        public void CreateCategory_StockParameterShort_ResultException()
        {
            Action action = () => new Product(1, "Produto", "Descrição", 160, -10, "google.com.br");

            action
                .Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid negative values for stock.");
        }
        #endregion

        #region Stock
        [Fact(DisplayName = "Url in product is invalid.")]
        public void CreateCategory_UrlParameterLong_ResultException()
        {
            Action action = () => new Product(1, "Produto", "Descrição", 160, 10, "googleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogleagoogle");

            action
                .Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid long URL, maximum 250 characteres.");
        }
        #endregion

        #endregion
    }
    #endregion
}
