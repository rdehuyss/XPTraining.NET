using System;
using Xunit;
using FluentAssertions;
using Refactoring.IntroduceParameterObject;

namespace Refactoring.Tests.IntroduceParameterObject
{
    public class AccountTest
    {
        private Account _account;

        public AccountTest()
        {
            _account = new Account();
        }

        [Fact]
        public void BeforeIntervalIsExcluded()
        {
            var beforeInterval = new Entry(10.0, new DateTime(2007, 1, 3));
            _account.Entries.Add(beforeInterval);

            var result = _account.GetFlowBetween(new DateTime(2007, 1, 4), new DateTime(2007, 2, 4));
            result.Should().Be(0.0);
        }

        [Fact]
        public void OnStartOfIntervalIsIncluded()
        {
            var startOfInterval = new Entry(10.0, new DateTime(2007, 1, 4));
            _account.Entries.Add(startOfInterval);

            var result = _account.GetFlowBetween(new DateTime(2007, 1, 4), new DateTime(2007, 2, 4));
            result.Should().Be(10.0);
        }

        [Fact]
        public void MiddleOfIntervalIsIncluded()
        {
            var middleOfInterval = new Entry(10.0, new DateTime(2007, 2, 2));
            _account.Entries.Add(middleOfInterval);

            var result = _account.GetFlowBetween(new DateTime(2007, 1, 4), new DateTime(2007, 2, 4));
            result.Should().Be(10.0);
        }

        [Fact]
        public void OnEndOfIntervalIsIncluded()
        {
            var endOfInterval = new Entry(10.0, new DateTime(2007, 2, 4));
            _account.Entries.Add(endOfInterval);

            var result = _account.GetFlowBetween(new DateTime(2007, 1, 4), new DateTime(2007, 2, 4));
            result.Should().Be(10.0);
        }

        [Fact]
        public void AfterIntervalIsExcluded()
        {
            var before = new Entry(10.0, new DateTime(2007, 2, 5));
            _account.Entries.Add(before);

            var result = _account.GetFlowBetween(new DateTime(2007, 1, 4), new DateTime(2007, 2, 4));
            result.Should().Be(0.0);
        }

        [Fact]
        public void MultipleEntriesInIntervalAreAccumulated()
        {
            var middleOfInterval = new Entry(10.0, new DateTime(2007, 2, 2));
            var endOfInterval = new Entry(10.0, new DateTime(2007, 2, 4));
            _account.Entries.Add(middleOfInterval);
            _account.Entries.Add(endOfInterval);

            var result = _account.GetFlowBetween(new DateTime(2007, 1, 4), new DateTime(2007, 2, 4));
            result.Should().Be(20.0);
        }
    }
}