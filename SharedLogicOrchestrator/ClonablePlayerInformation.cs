using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using InventorySystem;
using System.Collections.Generic;
using UnityEngine;

namespace SharedLogicOrchestrator
{
	public class CloneablePlayerInformation
	{




		//
		// Summary:
		//     Gets the player's InventorySystem.Inventory.
		public Inventory Inventory
		{
			get;
			private set;
		}

		//
		// Summary:
		//     Gets the player's ammo.
		public Dictionary<ItemType, ushort> Ammo
		{
			get;
			set;

		}

		public Exiled.API.Features.Roles.Role Role
		{
			get;
			set;
		}

		//
		// Summary:
		//     Gets or sets a value indicating whether the player's friendly fire is enabled.
		//     This property only determines if this player can deal damage to players on the
		//     same team; This player can be damaged by other players on their own team even
		//     if this property is false.
		//
		// Remarks:
		//     This property currently does not function, and is planned to be re-implemented
		//     in the future.
		public bool IsFriendlyFireEnabled
		{
			get;
			set;
		}





		//
		// Summary:
		//     Gets or sets the player's health. If the health is greater than the Exiled.API.Features.Player.MaxHealth,
		//     the MaxHealth will also be changed to match the health.
		public float Health
		{
			get;
			set;
		}

		//
		// Summary:
		//     Gets or sets the player's maximum health.
		public int MaxHealth
		{
			get;
			set;
		}

		//
		// Summary:
		//     Gets or sets the player's artificial health. If the health is greater than the
		//     Exiled.API.Features.Player.MaxArtificialHealth, it will also be changed to match
		//     the artificial health.
		public float ArtificialHealth
		{
			get;
			set;
		}

		//
		// Summary:
		//     Gets or sets the player's maximum artificial health.
		public float MaxArtificialHealth
		{
			get;
			set;
		}

		//
		// Summary:
		//     Gets the Stamina class.
		public Stamina Stamina
		{
			get;
			set;
		}

		//
		// Summary:
		//     Gets or sets the player's group name.
		public string GroupName
		{
			get;
			set;
		}

		//
		// Summary:
		//     Gets the current room the player is in.
		public Room CurrentRoom
		{
			get;
			set;
		}

		//
		// Summary:
		//     Gets the current zone the player is in.
		public ZoneType Zone
		{
			get;
			set;
		}

		public List<Item> ItemsValue = new List<Item>(8);


		public ICollection<Item> Items
		{
			get;
			set;
		}



		public CloneablePlayerInformation()
		{

		}

		public bool IsScp
		{
			get;
			set;
		}

		public Vector3 Position
		{
			get;
			set;
		}

		public int Id
		{
			get;
			set;
		}
		public string Nickname
		{
			get;
			set;
		}

		public byte scp079lvl
		{
			get;
			set;
		}

		public float scp079exp
		{
			get;
			set;
		}


		public bool isSpy
		{
			get;
			set;
		}

		public CloneablePlayerInformation(Player playerInformation)
		{
			Inventory = playerInformation.Inventory;
			Ammo = playerInformation.Ammo;
			Role = playerInformation.Role;
			if (Role == RoleType.Scp079)
			{
				scp079lvl = playerInformation.ReferenceHub.scp079PlayerScript.Lvl;
				scp079exp = playerInformation.ReferenceHub.scp079PlayerScript.Exp;
			}
			IsFriendlyFireEnabled = playerInformation.IsFriendlyFireEnabled;
			Health = playerInformation.Health;
			MaxHealth = playerInformation.MaxHealth;
			ArtificialHealth = playerInformation.ArtificialHealth;
			MaxArtificialHealth = (playerInformation.MaxArtificialHealth);
			Stamina = playerInformation.Stamina;
			GroupName = playerInformation.GroupName;
			CurrentRoom = playerInformation.CurrentRoom;
			Zone = playerInformation.Zone;
			IsScp = playerInformation.IsScp;
			Position = playerInformation.Position;
			Id = playerInformation.Id;
			Nickname = playerInformation.Nickname;


			Items = new List<Item>(8);

			foreach (Item playerItem in playerInformation.Items)
			{
				Items.Add(playerItem);
			}


		}

		public override string ToString()
		{
			return ReflectionHelpers.toStringObject("CloneablePlayerInformation: ", this);
		}

		public static CloneablePlayerInformation clonePlayer(Player currPlayer)
		{
			return new CloneablePlayerInformation(currPlayer);
		}
	}
}
