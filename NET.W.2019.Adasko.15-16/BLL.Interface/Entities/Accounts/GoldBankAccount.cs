﻿//-----------------------------------------------------------------------
// <copyright file="GoldBankAccount.cs" company="EpamTraining">
//     All rights reserved.
// </copyright>
// <author>Eduard Adasko</author>
//-----------------------------------------------------------------------

namespace BLL.Interface.Entities
{
    using BLL.Interface.Interfaces;

    /// <summary>
    /// Gold bank account class with increased bonus coefficients.
    /// </summary>
    public class GoldBankAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoldBankAccount"/> class.
        /// </summary>
        /// <param name="id">
        /// Id value.
        /// </param>
        /// <param name="name">
        /// Owner name value.
        /// </param>
        public GoldBankAccount(int id, string name) : base(id, name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoldBankAccount"/> class.
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
        /// <param name="bonusProgram">
        /// Type of bonus program.
        /// </param>
        public GoldBankAccount(int id, string name, decimal balance, double bonusPoints, IAccountBonus bonusProgram)
            : base(id, name, balance, bonusPoints, bonusProgram)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoldBankAccount"/> class.
        /// </summary>
        /// <param name="id">Id value.</param>
        /// <param name="name">Owner name value.</param>
        /// <param name="bonusProgram">Type od bonus program.</param>
        public GoldBankAccount(int id, string name, IAccountBonus bonusProgram)
            : base(id, name, bonusProgram)
        {
        }

        /// <inheritdoc/> 
        public override double DepositBalanceCoefficient => 0.7;

        /// <inheritdoc/> 
        public override double DepositValueCoefficient => 0.7;

        /// <inheritdoc/> 
        public override double WithdrawBalanceCoefficient => 0;

        /// <inheritdoc/> 
        public override double WithdrawValueCoefficient => 0;

        /// <inheritdoc/> 
        public override AccountType GetAccountType() => AccountType.Gold;
    }
}
