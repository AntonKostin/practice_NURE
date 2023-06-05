using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practice_TrekCompany.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brakes",
                columns: table => new
                {
                    brakeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brakeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brakes", x => x.brakeId);
                });

            migrationBuilder.CreateTable(
                name: "Carriages",
                columns: table => new
                {
                    carriageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carriageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carriageQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carriages", x => x.carriageId);
                });

            migrationBuilder.CreateTable(
                name: "Cassettes",
                columns: table => new
                {
                    cassetteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cassetteName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cassettes", x => x.cassetteId);
                });

            migrationBuilder.CreateTable(
                name: "Factories",
                columns: table => new
                {
                    factoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zipCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factories", x => x.factoryId);
                });

            migrationBuilder.CreateTable(
                name: "Forks",
                columns: table => new
                {
                    forkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    forkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    forkDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    forkQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forks", x => x.forkId);
                });

            migrationBuilder.CreateTable(
                name: "Frames",
                columns: table => new
                {
                    frameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    frameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    frameDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    frameQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frames", x => x.frameId);
                });

            migrationBuilder.CreateTable(
                name: "Gripses",
                columns: table => new
                {
                    gripsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gripsName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gripses", x => x.gripsId);
                });

            migrationBuilder.CreateTable(
                name: "Handlebars",
                columns: table => new
                {
                    handlbarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    handlbarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Handlebars", x => x.handlbarId);
                });

            migrationBuilder.CreateTable(
                name: "Hubs",
                columns: table => new
                {
                    hubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hubName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hubDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hubQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hubs", x => x.hubId);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    jobTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.jobTitleId);
                });

            migrationBuilder.CreateTable(
                name: "Pedalses",
                columns: table => new
                {
                    pedalsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pedalsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pedalsQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedalses", x => x.pedalsId);
                });

            migrationBuilder.CreateTable(
                name: "Rims",
                columns: table => new
                {
                    rimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rimName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rimDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rimQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rims", x => x.rimId);
                });

            migrationBuilder.CreateTable(
                name: "Saddles",
                columns: table => new
                {
                    saddleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    saddleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saddles", x => x.saddleId);
                });

            migrationBuilder.CreateTable(
                name: "SeatPosts",
                columns: table => new
                {
                    seatPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seatPostName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatPosts", x => x.seatPostId);
                });

            migrationBuilder.CreateTable(
                name: "Shifters",
                columns: table => new
                {
                    shifterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shifterName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifters", x => x.shifterId);
                });

            migrationBuilder.CreateTable(
                name: "Steerings",
                columns: table => new
                {
                    steeringId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    steeringName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steerings", x => x.steeringId);
                });

            migrationBuilder.CreateTable(
                name: "Stems",
                columns: table => new
                {
                    stemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stemName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stems", x => x.stemId);
                });

            migrationBuilder.CreateTable(
                name: "Switches",
                columns: table => new
                {
                    switchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    switchName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Switches", x => x.switchId);
                });

            migrationBuilder.CreateTable(
                name: "Tires",
                columns: table => new
                {
                    tireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tireName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tireDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tireQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tires", x => x.tireId);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfBikes",
                columns: table => new
                {
                    typeOfBikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfBikes", x => x.typeOfBikeId);
                });

            migrationBuilder.CreateTable(
                name: "Framesets",
                columns: table => new
                {
                    framesetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    frameId = table.Column<int>(type: "int", nullable: false),
                    forkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Framesets", x => x.framesetId);
                    table.ForeignKey(
                        name: "FK_Framesets_Forks_forkId",
                        column: x => x.forkId,
                        principalTable: "Forks",
                        principalColumn: "forkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Framesets_Frames_frameId",
                        column: x => x.frameId,
                        principalTable: "Frames",
                        principalColumn: "frameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    staffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    secondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    factoryId = table.Column<int>(type: "int", nullable: false),
                    jobTitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.staffId);
                    table.ForeignKey(
                        name: "FK_Staffs_Factories_factoryId",
                        column: x => x.factoryId,
                        principalTable: "Factories",
                        principalColumn: "factoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffs_JobTitles_jobTitleId",
                        column: x => x.jobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "jobTitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    equipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brakeId = table.Column<int>(type: "int", nullable: false),
                    saddleId = table.Column<int>(type: "int", nullable: false),
                    seatPostId = table.Column<int>(type: "int", nullable: false),
                    stemId = table.Column<int>(type: "int", nullable: false),
                    handlebarId = table.Column<int>(type: "int", nullable: false),
                    gripsId = table.Column<int>(type: "int", nullable: false),
                    steeringId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.equipmentId);
                    table.ForeignKey(
                        name: "FK_Equipments_Brakes_brakeId",
                        column: x => x.brakeId,
                        principalTable: "Brakes",
                        principalColumn: "brakeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Gripses_gripsId",
                        column: x => x.gripsId,
                        principalTable: "Gripses",
                        principalColumn: "gripsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Handlebars_handlebarId",
                        column: x => x.handlebarId,
                        principalTable: "Handlebars",
                        principalColumn: "handlbarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Saddles_saddleId",
                        column: x => x.saddleId,
                        principalTable: "Saddles",
                        principalColumn: "saddleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_SeatPosts_seatPostId",
                        column: x => x.seatPostId,
                        principalTable: "SeatPosts",
                        principalColumn: "seatPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Steerings_steeringId",
                        column: x => x.steeringId,
                        principalTable: "Steerings",
                        principalColumn: "steeringId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Stems_stemId",
                        column: x => x.stemId,
                        principalTable: "Stems",
                        principalColumn: "stemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transmitions",
                columns: table => new
                {
                    transmitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cassetteId = table.Column<int>(type: "int", nullable: false),
                    switchId = table.Column<int>(type: "int", nullable: false),
                    shifterId = table.Column<int>(type: "int", nullable: false),
                    transmitionQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmitions", x => x.transmitionId);
                    table.ForeignKey(
                        name: "FK_Transmitions_Cassettes_cassetteId",
                        column: x => x.cassetteId,
                        principalTable: "Cassettes",
                        principalColumn: "cassetteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transmitions_Shifters_shifterId",
                        column: x => x.shifterId,
                        principalTable: "Shifters",
                        principalColumn: "shifterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transmitions_Switches_switchId",
                        column: x => x.switchId,
                        principalTable: "Switches",
                        principalColumn: "switchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wheelsets",
                columns: table => new
                {
                    wheelsetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hubId = table.Column<int>(type: "int", nullable: false),
                    rimId = table.Column<int>(type: "int", nullable: false),
                    tireId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheelsets", x => x.wheelsetId);
                    table.ForeignKey(
                        name: "FK_Wheelsets_Hubs_hubId",
                        column: x => x.hubId,
                        principalTable: "Hubs",
                        principalColumn: "hubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wheelsets_Rims_rimId",
                        column: x => x.rimId,
                        principalTable: "Rims",
                        principalColumn: "rimId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wheelsets_Tires_tireId",
                        column: x => x.tireId,
                        principalTable: "Tires",
                        principalColumn: "tireId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groopsets",
                columns: table => new
                {
                    groopsetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transmitionId = table.Column<int>(type: "int", nullable: false),
                    carriageId = table.Column<int>(type: "int", nullable: false),
                    pedalsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groopsets", x => x.groopsetId);
                    table.ForeignKey(
                        name: "FK_Groopsets_Carriages_carriageId",
                        column: x => x.carriageId,
                        principalTable: "Carriages",
                        principalColumn: "carriageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Groopsets_Pedalses_pedalsId",
                        column: x => x.pedalsId,
                        principalTable: "Pedalses",
                        principalColumn: "pedalsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Groopsets_Transmitions_transmitionId",
                        column: x => x.transmitionId,
                        principalTable: "Transmitions",
                        principalColumn: "transmitionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    bikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bikeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bikeImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bikeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bikePrice = table.Column<int>(type: "int", nullable: false),
                    bikeWeight = table.Column<float>(type: "real", nullable: false),
                    framesetId = table.Column<int>(type: "int", nullable: false),
                    wheelsetId = table.Column<int>(type: "int", nullable: false),
                    groopsetId = table.Column<int>(type: "int", nullable: false),
                    equipmentId = table.Column<int>(type: "int", nullable: false),
                    typeOfBikeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.bikeId);
                    table.ForeignKey(
                        name: "FK_Bikes_Equipments_equipmentId",
                        column: x => x.equipmentId,
                        principalTable: "Equipments",
                        principalColumn: "equipmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bikes_Framesets_framesetId",
                        column: x => x.framesetId,
                        principalTable: "Framesets",
                        principalColumn: "framesetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bikes_Groopsets_groopsetId",
                        column: x => x.groopsetId,
                        principalTable: "Groopsets",
                        principalColumn: "groopsetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bikes_TypeOfBikes_typeOfBikeId",
                        column: x => x.typeOfBikeId,
                        principalTable: "TypeOfBikes",
                        principalColumn: "typeOfBikeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bikes_Wheelsets_wheelsetId",
                        column: x => x.wheelsetId,
                        principalTable: "Wheelsets",
                        principalColumn: "wheelsetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_equipmentId",
                table: "Bikes",
                column: "equipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_framesetId",
                table: "Bikes",
                column: "framesetId");

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_groopsetId",
                table: "Bikes",
                column: "groopsetId");

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_typeOfBikeId",
                table: "Bikes",
                column: "typeOfBikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_wheelsetId",
                table: "Bikes",
                column: "wheelsetId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_brakeId",
                table: "Equipments",
                column: "brakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_gripsId",
                table: "Equipments",
                column: "gripsId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_handlebarId",
                table: "Equipments",
                column: "handlebarId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_saddleId",
                table: "Equipments",
                column: "saddleId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_seatPostId",
                table: "Equipments",
                column: "seatPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_steeringId",
                table: "Equipments",
                column: "steeringId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_stemId",
                table: "Equipments",
                column: "stemId");

            migrationBuilder.CreateIndex(
                name: "IX_Framesets_forkId",
                table: "Framesets",
                column: "forkId");

            migrationBuilder.CreateIndex(
                name: "IX_Framesets_frameId",
                table: "Framesets",
                column: "frameId");

            migrationBuilder.CreateIndex(
                name: "IX_Groopsets_carriageId",
                table: "Groopsets",
                column: "carriageId");

            migrationBuilder.CreateIndex(
                name: "IX_Groopsets_pedalsId",
                table: "Groopsets",
                column: "pedalsId");

            migrationBuilder.CreateIndex(
                name: "IX_Groopsets_transmitionId",
                table: "Groopsets",
                column: "transmitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_factoryId",
                table: "Staffs",
                column: "factoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_jobTitleId",
                table: "Staffs",
                column: "jobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmitions_cassetteId",
                table: "Transmitions",
                column: "cassetteId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmitions_shifterId",
                table: "Transmitions",
                column: "shifterId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmitions_switchId",
                table: "Transmitions",
                column: "switchId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheelsets_hubId",
                table: "Wheelsets",
                column: "hubId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheelsets_rimId",
                table: "Wheelsets",
                column: "rimId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheelsets_tireId",
                table: "Wheelsets",
                column: "tireId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bikes");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Framesets");

            migrationBuilder.DropTable(
                name: "Groopsets");

            migrationBuilder.DropTable(
                name: "TypeOfBikes");

            migrationBuilder.DropTable(
                name: "Wheelsets");

            migrationBuilder.DropTable(
                name: "Factories");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "Brakes");

            migrationBuilder.DropTable(
                name: "Gripses");

            migrationBuilder.DropTable(
                name: "Handlebars");

            migrationBuilder.DropTable(
                name: "Saddles");

            migrationBuilder.DropTable(
                name: "SeatPosts");

            migrationBuilder.DropTable(
                name: "Steerings");

            migrationBuilder.DropTable(
                name: "Stems");

            migrationBuilder.DropTable(
                name: "Forks");

            migrationBuilder.DropTable(
                name: "Frames");

            migrationBuilder.DropTable(
                name: "Carriages");

            migrationBuilder.DropTable(
                name: "Pedalses");

            migrationBuilder.DropTable(
                name: "Transmitions");

            migrationBuilder.DropTable(
                name: "Hubs");

            migrationBuilder.DropTable(
                name: "Rims");

            migrationBuilder.DropTable(
                name: "Tires");

            migrationBuilder.DropTable(
                name: "Cassettes");

            migrationBuilder.DropTable(
                name: "Shifters");

            migrationBuilder.DropTable(
                name: "Switches");
        }
    }
}
