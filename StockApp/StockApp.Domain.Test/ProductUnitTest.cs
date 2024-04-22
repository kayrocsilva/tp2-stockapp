using FluentAssertions;
using StockApp.Domain.Entities;
using StockApp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StockApp.Domain.Test
{
    public class ProductUnitTest
    {
        [Fact(DisplayName = "Create Product With Valid State")]
        public void CreateProduct_WithValidParameters_ShouldNotThrowResultValidState()
        {
            Action action = () => new Product(1, "name", "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Id")]
        public void CreateProduct_WithValidId_ResultValidState()
        {
            Action action = () => new Product(1, "name", "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Name")]
        public void CreateProduct_WithValidName_ResultValidState()
        {
            Action action = () => new Product(1, "valid name", "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Description")]
        public void CreateProduct_WithValidDescription_ResultValidState()
        {
            Action action = () => new Product(1, "name", "valid description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Price")]
        public void CreateProduct_WithValidPrice_ResultValidState()
        {
            Action action = () => new Product(1, "name", "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Stock")]
        public void CreateProduct_WithValidStock_ResultValidState()
        {
            Action action = () => new Product(1, "name", "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Image")]
        public void CreateProduct_WithValidImage_ResultValidState()
        {
            Action action = () => new Product(1, "name", "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid CategoryId")]
        public void CreateProduct_WithValidCategoryId_ResultValidState()
        {
            Action action = () => new Product(1, "name", "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }


        [Fact(DisplayName = "Create Product With Invalid Id")]
        public void CreateProduct_WithInvalidId_ResultInvalidState()
        {
            Action action = () => new Product(-1, "name", "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid Id, Id must be greater than zero.");
        }

        [Fact(DisplayName = "Create Product With Invalid Name")]
        public void CreateProduct_WithInvalidNameNull_ResultInvalidState()
        {
            Action action = () => new Product(1, null, "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product With Invalid Name")]
        public void CreateProduct_WithInvalidNameEmpty_ResultInvalidState()
        {
            Action action = () => new Product(1, "", "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product With Invalid Name")]
        public void CreateProduct_WithInvalidNameTooShort_ResultInvalidState()
        {
            Action action = () => new Product(1, "NA", "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Product With Invalid Name")]
        public void CreateProduct_WithInvalidNameTooLong_ResultInvalidState()
        {
            Action action = () => new Product(1, "ProductNameProductNameProductNameProductNameProductNameProductNameProductNameProductNameProductNamePr", "description", 10.55m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, too long, maximum 100 characters.");
        }

        [Fact(DisplayName = "Create Product With Invalid Description")]
        public void CreateProduct_WithInvalidDescriptionNull_ResultInvalidState()
        {
            Action action = () => new Product(1, "name", null, 10.55m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid description, description is required.");
        }

        [Fact(DisplayName = "Create Product With Invalid Description")]
        public void CreateProduct_WithInvalidDescriptionEmpty_ResultInvalidState()
        {
            Action action = () => new Product(1, "name", "", 10.55m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid description, description is required.");
        }

        [Fact(DisplayName = "Create Product With Invalid Description")]
        public void CreateProduct_WithInvalidDescriptionTooShort_ResultInvalidState()
        {
            Action action = () => new Product(1, "name", "DESC", 10.55m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid description, too short, minimum 5 characters.");
        }

        [Fact(DisplayName = "Create Product With Invalid Description")]
        public void CreateProduct_WithInvalidDescriptionTooLong_ResultInvalidState()
        {
            Action action = () => new Product(1, "name", "ProductDescriptionProductDescriptionProductDescriptionProductDescriptionProductDescriptionProductDescriptionProductDescriptionProductDescriptionProductDescriptionProductDescriptionProductDescriptionPro", 10.55m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid description, too long, maximum 200 characters.");
        }

        [Fact(DisplayName = "Create Product With Invalid Price")]
        public void CreateProduct_WithInvalidPrice_ResultInvalidState()
        {
            Action action = () => new Product(1, "name", "description", -10.55m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid price negative value.");
        }

        [Fact(DisplayName = "Create Product With Invalid Price")]
        public void CreateProduct_WithInvalidPriceNull_ResultInvalidState()
        {
            Action action = () => new Product(1, "name", "description", 0, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid price, price is required");
        }

        [Fact(DisplayName = "Create Product With Invalid Price")]
        public void CreateProduct_WithInvalidPriceTooLong_ResultInvalidState()
        {
            Action action = () => new Product(1, "name", "description", 10.555m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid price must have exactly two decimal places.");
        }

        [Fact(DisplayName = "Create Product With Invalid Stock")]
        public void CreateProduct_WithInvalidStock_ResultInvalidState()
        {
            Action action = () => new Product(1, "name", "description", 10.55m, -1, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid stock negative value.");
        }

        [Fact(DisplayName = "Create Product With Invalid Image")]
        public void CreateProduct_WithInvalidImageTooLong_ResultInvalidState()
        {
            Action action = () => new Product(1, "name", "description", 10.55m, 100, "test_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jpgtest_image.jp", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid image name, too long, maximum 250 characters.");
        }

        [Fact(DisplayName = "Create Product With Invalid Image")]
        public void CreateProduct_WithInvalidImageTooShort_ResultInvalidState()
        {
            Action action = () => new Product(1, "name", "description", 10.55m, 100, ".jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid image name, too short, minimum 5 characteres.");
        }

        [Fact(DisplayName = "Create Product With Invalid categoryid")]
        public void CreateProduct_WithInvalidcategoryid_ResultInvalidState()
        {
            Action action = () => new Product(1, "name", "description", 10.55m, 100, "image.jpg", 0);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid category ID, must be greater than zero.");
        }

    }
}
