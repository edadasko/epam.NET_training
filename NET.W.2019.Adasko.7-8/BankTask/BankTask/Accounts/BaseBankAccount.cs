﻿//-----------------------------------------------------------------------
// <copyright file="BaseBankAccount.cs" company="EpamTraining">
//     All rights reserved.
// </copyright>
// <author>Eduard Adasko</author>
//-----------------------------------------------------------------------

namespace BankTask.Accounts
{
    using System;

    /// <summary>
    /// Base bank account class with standart bonus coefficients.
    /// </summary>
    [Serializable]
    public class BaseBankAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseBankAccount"/> class.
        /// </summary>
        /// <param name="id">
        /// Id value.
        /// </param>
        /// <param name="name">
        /// Owner name value.
        /// </param>
        public BaseBankAccount(int id, string name) : base(id, name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseBankAccount"/> class.
        /// </summary>
        /// <param name="id">
        /// Id value.
        /// </param>
        /// <param name="name">
        /// Owner name value.
        /// </param>
        /// <param name="balance">
        /// Balance value.
        /// </param>
        /// <param name="bonusPoints">
        /// Bonus points value.
        /// </param>
        public BaseBankAccount(int id, string name, decimal balance, double bonusPoints)
            : base(id, name, balance, bonusPoints)
        {
        }

        /// <inheritdoc/> 
        public override double DepositBalanceCoefficient => 0.1;

        /// <inheritdoc/> 
        public override double DepositValueCoefficient => 0.1;

        /// <inheritdoc/> 
        public override double WithdrawBalanceCoefficient => 0.05;

        /// <inheritdoc/> 
        public override double WithdrawValueCoefficient => 0.05;
    }
}
