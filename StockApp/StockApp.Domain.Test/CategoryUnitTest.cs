using FluentAssertions;
using StockApp.Domain.Entities;
using StockApp.Domain.Validation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StockApp.Domain.Test
{
    public class CategoryUnitTest
    {

        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultValidState()
        {
            Action action = () => new Category(1, "Category");
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Category With Invalid Id")]
        public void CreateCategory_WithInvalidId_ResultInvalidState()
        {
            Action action = () => new Category(-1, "Ca");
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid id value.");
        }

        [Fact(DisplayName = "Create Category With Invalid Name")]
        public void CreateCategory_WithInvalidNameNull_ResultInvalidState()
        {
            Action action = () => new Category(1, null);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Category With Invalid Name")]
        public void CreateCategory_WithInvalidNameTooShort_ResultInvalidState()
        {
            Action action = () => new Category(1, "CA");
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Category With Invalid Name")]
        public void CreateCategory_WithInvalidNameTooLong_ResultInvalidState()
        {
            Action action = () => new Category(1, "CATEGORYCATEGORYCATEGORYCATEGORYCATEGORYCATEGORYCATEGORYCATEGORYCATEGORYCATEGORYCATEGORYCATEGORYCATEG");
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, too long, maximum 100 characteres.");
        }

    }
}
