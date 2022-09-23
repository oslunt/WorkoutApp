using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkoutApp.Migrations
{
    public partial class WE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stats_Exercises_ExerciseID",
                table: "Stats");

            migrationBuilder.DropForeignKey(
                name: "FK_Stats_Workouts_WorkoutID",
                table: "Stats");

            migrationBuilder.DropIndex(
                name: "IX_Stats_ExerciseID",
                table: "Stats");

            migrationBuilder.DropIndex(
                name: "IX_Stats_WorkoutID",
                table: "Stats");

            migrationBuilder.DropColumn(
                name: "ExerciseID",
                table: "Stats");

            migrationBuilder.DropColumn(
                name: "WorkoutID",
                table: "Stats");

            migrationBuilder.AddColumn<int>(
                name: "WorkoutExerciseID",
                table: "Stats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Workout_ExerciseWorkoutExerciseID",
                table: "Stats",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stats_Workout_ExerciseWorkoutExerciseID",
                table: "Stats",
                column: "Workout_ExerciseWorkoutExerciseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stats_Workout_Exercises_Workout_ExerciseWorkoutExerciseID",
                table: "Stats",
                column: "Workout_ExerciseWorkoutExerciseID",
                principalTable: "Workout_Exercises",
                principalColumn: "WorkoutExerciseID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stats_Workout_Exercises_Workout_ExerciseWorkoutExerciseID",
                table: "Stats");

            migrationBuilder.DropIndex(
                name: "IX_Stats_Workout_ExerciseWorkoutExerciseID",
                table: "Stats");

            migrationBuilder.DropColumn(
                name: "WorkoutExerciseID",
                table: "Stats");

            migrationBuilder.DropColumn(
                name: "Workout_ExerciseWorkoutExerciseID",
                table: "Stats");

            migrationBuilder.AddColumn<int>(
                name: "ExerciseID",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkoutID",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stats_ExerciseID",
                table: "Stats",
                column: "ExerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_WorkoutID",
                table: "Stats",
                column: "WorkoutID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stats_Exercises_ExerciseID",
                table: "Stats",
                column: "ExerciseID",
                principalTable: "Exercises",
                principalColumn: "ExerciseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stats_Workouts_WorkoutID",
                table: "Stats",
                column: "WorkoutID",
                principalTable: "Workouts",
                principalColumn: "WorkoutID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
