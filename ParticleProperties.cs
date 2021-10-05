using System;

namespace A1
{
	namespace ParticleProperties
    {
		public class ParticleMovement
		{
			public const int BASE_MOVEMENT = 3;
			public const int GRAVITY_MOVEMENT = 2;

			//public decimal MagneticMultiplier = 1M;
			//public int GravityMovement = 0;
			

			public enum MagneticFieldOnOff
			{
				On = 1,
				Off = 0
			}

			public enum Gravity
			{
				On = GRAVITY_MOVEMENT,
				Off = 0
			}

			private int movementRange;
			private int gravitationalField = 0;
			private decimal magneticField = 1M;

			public int DistanceMoved;


			/// <summary>
			/// Sets and gets the particle movementRange
			/// </summary>
			/// <param name="movementRange"></param>
			public ParticleMovement(int movementRange = BASE_MOVEMENT)
			{
				MovementRange = movementRange;
			}

			///<summary>
			///lambda exression to get the movement range, 
			///sets the movementRange, also calls the CalculateDistance method
			///</summary>
			public int MovementRange
			{
				get => movementRange;
				set
				{
					movementRange = value;
					CalculateDistance();
				}
			}
			/// <summary>
			/// lambda expression to set the gravitationalField property,
			/// sets the gravitationalField as well as calls the CalculateDistance method
			/// </summary>
			public int GravitationalField
			{
				get => gravitationalField;
				set
				{
					gravitationalField = value;
					CalculateDistance();
				}
			}

			/// <summary>
			/// set and get the auto-implemented Distance property
			/// </summary>
			public int Distance { get; private set; }

			private void CalculateDistance()
			{
				DistanceMoved = (int)(MovementRange * MagneticField) + BASE_MOVEMENT + GravitationalField;
			}
			public decimal MagneticField
			{
				get => magneticField;
				set
				{
					switch (value)
					{
						case (int)MagneticFieldOnOff.Off:
							magneticField = 1M;
							break;

						case (int)MagneticFieldOnOff.On:
							magneticField = 1.75M;
							break;
					}

					CalculateDistance();
				}
				/*public void SetMagneticField(bool magneticField)
				{
					MagneticMultiplier = magneticField ? 1.75M : 1M;
					CalculateDistance();
				}*/
			}
		}
	}
	
}
