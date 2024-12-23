using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    /// <inheritdoc />
    public partial class create_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxDebt = table.Column<float>(type: "real", nullable: false),
                    MaxCredit = table.Column<float>(type: "real", nullable: false),
                    IsReadOnly = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_accounts_accounts_ParentId",
                        column: x => x.ParentId,
                        principalTable: "accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "accountsDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountsDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "accountsDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<long>(type: "bigint", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountsDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_accountsDetails_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "accountingDocumentDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountingDocumentId = table.Column<long>(type: "bigint", nullable: false),
                    AccountId = table.Column<long>(type: "bigint", nullable: false),
                    Credit = table.Column<float>(type: "real", nullable: false),
                    Debth = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountingDocumentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_accountingDocumentDetails_accountsDocuments_AccountingDocumentId",
                        column: x => x.AccountingDocumentId,
                        principalTable: "accountsDocuments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_accountingDocumentDetails_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "invoiceHeaders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterarId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DocId = table.Column<long>(type: "bigint", nullable: true),
                    PaymentDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteringDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditorId = table.Column<long>(type: "bigint", nullable: false),
                    DebtorId = table.Column<long>(type: "bigint", nullable: false),
                    Desicount = table.Column<float>(type: "real", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoiceHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_invoiceHeaders_AspNetUsers_RegisterarId",
                        column: x => x.RegisterarId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_invoiceHeaders_accountsDocuments_DocId",
                        column: x => x.DocId,
                        principalTable: "accountsDocuments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_invoiceHeaders_accounts_CreditorId",
                        column: x => x.CreditorId,
                        principalTable: "accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_invoiceHeaders_accounts_DebtorId",
                        column: x => x.DebtorId,
                        principalTable: "accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RegisterarId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DebtorId = table.Column<long>(type: "bigint", nullable: false),
                    CreditorId = table.Column<long>(type: "bigint", nullable: false),
                    DocId = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payments_AspNetUsers_RegisterarId",
                        column: x => x.RegisterarId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_payments_accountsDocuments_DocId",
                        column: x => x.DocId,
                        principalTable: "accountsDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_payments_accounts_CreditorId",
                        column: x => x.CreditorId,
                        principalTable: "accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_payments_accounts_DebtorId",
                        column: x => x.DebtorId,
                        principalTable: "accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_productGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "productGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "invoicePayments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceHeaderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoicePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_invoicePayments_invoiceHeaders_InvoiceHeaderId",
                        column: x => x.InvoiceHeaderId,
                        principalTable: "invoiceHeaders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_invoicePayments_payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "payments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "invoiceDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceHeaderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    UnitPrice = table.Column<float>(type: "real", nullable: false),
                    Volume = table.Column<float>(type: "real", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoiceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_invoiceDetails_invoiceHeaders_InvoiceHeaderId",
                        column: x => x.InvoiceHeaderId,
                        principalTable: "invoiceHeaders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_invoiceDetails_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_accountingDocumentDetails_AccountId",
                table: "accountingDocumentDetails",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_accountingDocumentDetails_AccountingDocumentId",
                table: "accountingDocumentDetails",
                column: "AccountingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_ParentId",
                table: "accounts",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_accountsDetails_AccountId",
                table: "accountsDetails",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceDetails_InvoiceHeaderId",
                table: "invoiceDetails",
                column: "InvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceDetails_ProductId",
                table: "invoiceDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceHeaders_CreditorId",
                table: "invoiceHeaders",
                column: "CreditorId");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceHeaders_DebtorId",
                table: "invoiceHeaders",
                column: "DebtorId");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceHeaders_DocId",
                table: "invoiceHeaders",
                column: "DocId");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceHeaders_RegisterarId",
                table: "invoiceHeaders",
                column: "RegisterarId");

            migrationBuilder.CreateIndex(
                name: "IX_invoicePayments_InvoiceHeaderId",
                table: "invoicePayments",
                column: "InvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_invoicePayments_PaymentId",
                table: "invoicePayments",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_payments_CreditorId",
                table: "payments",
                column: "CreditorId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_DebtorId",
                table: "payments",
                column: "DebtorId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_DocId",
                table: "payments",
                column: "DocId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_RegisterarId",
                table: "payments",
                column: "RegisterarId");

            migrationBuilder.CreateIndex(
                name: "IX_products_GroupId",
                table: "products",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accountingDocumentDetails");

            migrationBuilder.DropTable(
                name: "accountsDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "invoiceDetails");

            migrationBuilder.DropTable(
                name: "invoicePayments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "invoiceHeaders");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "productGroups");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "accountsDocuments");

            migrationBuilder.DropTable(
                name: "accounts");
        }
    }
}
