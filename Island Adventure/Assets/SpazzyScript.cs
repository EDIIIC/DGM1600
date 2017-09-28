using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpazzyScript : MonoBehaviour {

	public Text textObject; 

	public enum States {shore, shore2, Mountainf, ExpBeach, Smoke, Ltree, NativesKilled, Village, Volcano, VolcanoDeath, NativeFavor, Sacrifice, VolSacrifice, PushChief, Monster, Nope, Rocks, Wreckage, Bugs, Poison, ShoreSearch, Dive, Captains, Hold, SharkDeath, PunchedS, shore3, shore4, drowned, dive2, HoldNShark};
	public States myState;


	void Start () {
		myState = States.shore;

	}

	void Update () {
		if (myState == States.shore) {
			State_shore ();
		} else if (myState == States.Mountainf) {
			State_Mountainf ();
		} else if (myState == States.ExpBeach) {
			State_ExpBeach ();
		} else if (myState == States.Smoke) {
			State_Smoke ();
		} else if (myState == States.Ltree) {
			State_Ltree ();
		} else if (myState == States.shore2) {
			State_shore2 ();
		} else if (myState == States.NativesKilled) {
			State_NativesKilled ();
		} else if (myState == States.Village) {
			State_Village ();
		} else if (myState == States.Volcano) {
			State_Volcano ();
		} else if (myState == States.VolcanoDeath) {
			State_VolcanoDeath ();
		} else if (myState == States.NativeFavor) {
			State_NativeFavor ();
		} else if (myState == States.Sacrifice) {
			State_Sacrifice ();
		} else if (myState == States.VolSacrifice) {
			State_VolSacrifice ();
		} else if (myState == States.PushChief) {
			State_PushChief ();
		} else if (myState == States.Monster) {
			State_Monster ();
		} else if (myState == States.Nope) {
			State_Nope ();
		} else if (myState == States.Rocks) {
			State_Rocks ();
		} else if (myState == States.Wreckage) {
			State_Wreckage ();
		} else if (myState == States.Bugs) {
			State_Bugs ();
		} else if (myState == States.Poison) {
			State_Poison ();
		} else if (myState == States.Dive) {
			State_Dive ();
		} else if (myState == States.ShoreSearch) {
			State_ShoreSearch ();
		} else if (myState == States.Captains) {
			State_Captains ();
		} else if (myState == States.Hold) {
			State_Hold ();
		} else if (myState == States.SharkDeath) {
			State_SharkDeath ();
		} else if (myState == States.PunchedS) {
			State_PunchedS ();
		} else if (myState == States.drowned) {
			State_drowned ();
		} else if (myState == States.shore3) {
			State_shore3 ();
		} else if (myState == States.shore4) {
			State_shore4 ();
		}else if (myState == States.dive2) {
				State_dive2 ();
		}else if (myState == States.HoldNShark) {
			State_HoldNShark ();
		}


	}

	void State_shore(){
		textObject.text = "You wake up on the shore of a small island," +
			"Your ship must have wrecked in last night's storm!" +
			"\nYou could explore an opening in the mountain forest before you " +
			"\nor you could start exploring the Beach." +
			"\n\nPress M for the Mountain Forest." +
			"\nPress B to explore the Beach.";

		if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.Mountainf;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.ExpBeach;
		}
	}

	void State_shore2(){
		textObject.text = "You are back to the shore of the island." +
			"\nYou could explore the Mountain Forest behind you " +
			"\nor start exploring the Beach." +
			"\n\nPress M for the Mountain Forest." +
			"\nPress B to explore the Beach.";

		if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.Mountainf;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.ExpBeach;
		}
	}

	void State_Mountainf(){
		textObject.text = "From the Mountain Forest you can see a Leaning Tree," +
		"\nbig enough to start a raft and unstable enough to knock over." +
		"\nYou can also see a pillar of Smoke. " +
		"\nMaybe civilization? It could at least provide heat for the night.." +
		"\n\nPress T to investigate the Leaning Tree." +
		"\nPress S to investigate Smoke." +
		"\nPress Return to go back to Shore";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore2;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.Ltree;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.Smoke;
		}
	}

	void State_Smoke(){
		textObject.text = "You found a stream of Lava!" +
			"\n\nPress F to follow it." +
			"\nPress Return to go back.";

		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.Volcano;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.Mountainf;
		}
	}

	void State_Volcano(){
		textObject.text = "You found a Volcano!" +
			"\nAnd is that obsidion down there? " +
			"\nYou could make tools!" +
			"\n\nPress I to investigate." +
			"\nPress G to go back.";

		if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.VolcanoDeath;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.Mountainf;
		}
	}

	void State_VolcanoDeath(){
		textObject.text = "You fell into the lava and burned to death." +
			"\n\nPress Return to Play Again." +
			"\nPress Escape to Close Game.";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore;
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	void State_Ltree(){
		textObject.text = "You are now at the Leaning tree." +
			"\n\nPress K to knock it over for a raft." +
			"\nPress G to go further." +
			"\nPress Return to go back to the forest opening.";

		if (Input.GetKeyDown (KeyCode.K)) {
			myState = States.NativesKilled;
		} else if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.Village;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.Mountainf;
		}
	}

	//Game Death
	void State_NativesKilled(){
		textObject.text = "Natives come running, you knocked over their sacred tree!" +
			"\nYou are killed." +
			"\n\nPress Return to Play Again." +
			"\nPress Escape to Close Game.";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore;
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	void State_Village(){
		textObject.text = "You found a village of peaceful natives!" +
			"\nPress T to talk to them." +
			"\nPress Return to go back.";

		if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.NativeFavor;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.Mountainf;
		}
	}

	void State_NativeFavor(){
		textObject.text = "They have several spare boats," +
			"\nand would be happy to give one to you!" +
			"\n..." +
			"\nIf you help them with a favor." +
			"\n\nPress Return to go back." +
			"\nPress H to help Natives";

		if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.Sacrifice;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.Mountainf;
		}
	}

	void State_Sacrifice(){
		textObject.text = "The village Chief and Shaman bring you to the top of the volcano," +
		"\nThey need a sacrifice to the Fire Gods!" +
		"\n\nPress O to offer your sacrifice." +
		"\nPress P to push them into the volcano!";

		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.VolSacrifice;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.PushChief;
		}
	}
		
	void State_VolSacrifice(){
		textObject.text = "You are the sacrifice!" +
		"\nYou are thrown into the lava and burn to death!" +
		"\n\nPress Return to Play again." +
		"\nPress Escape to Close Game.";

			if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore;
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
				Application.Quit ();
		}
	}
				
	void State_PushChief(){
		textObject.text = "You pushed the two into the volcano!" +
			"\nFeel guilty?" +
			"\n\nPress Y for yes." +
			"\nPress N for no.";

		if (Input.GetKeyDown (KeyCode.Y)) {
			myState = States.Monster;
		} else if (Input.GetKeyDown (KeyCode.N)) {
			myState = States.Nope;
		}
	}

	void State_Monster(){
		textObject.text = "You're a terrible human being." +
			"\nMaybe they would have simply had you" +
			"\n sing a song or kill a chicken?" +
			"\nThe guilt is too much, you jump into the volcano." +
			"\n\nPress Return to Play again." +
			"\nPress Escape to Close Game.";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore;
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	void State_Nope(){
		textObject.text = "Now's your chance to raid the village!" +
			"\nYou head back to the village and take food and a boat." +
			"\nYou Live!" +
			"\n\nPress Return to Play again." +
			"\nPress Escape to Close Game.";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore;
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	void State_ExpBeach(){
		textObject.text = "From the beach you see Ship Wreckage and Rocks." +
		"\n\nPress W to explore Wreckage." +
		"\nPress R to explore Rocks" +
		"\nPress Return to go back.";

		if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.Wreckage;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.Rocks;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore2;
		}
	}

	void State_Rocks(){
		textObject.text = "You found Crabs, dinner!" +
			"\n\nPress L to look further." +
			"\nPress Return to go back.";

		if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.Bugs;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.ExpBeach;
		}
	}

	void State_Bugs(){
		textObject.text = "You found some small insects." +
			"\nMaybe an appitizer?" +
			"\n\nPress C to collect." +
			"\nPress Return to go back.";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.Poison;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.ExpBeach;
		}
	}

	void State_Poison(){
		textObject.text = "The insects were poisonous!" +
			"\nYou are thrown into the lava and burn to death!"+
			"\n\nPress Return to Play Again." +
			"\nPress Escape to Close Game";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore;
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	void State_Wreckage(){
		textObject.text = "You can see some wreckage on shore," +
			"\nbut you know that most of the survival gear and supplies" +
			"\nis still in the ship's sunken hull." +
			"\n\nPress S to search the shore." +
			"\nPress D to dive into the water to search the hull." +
			"\nPress Return to go back.";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ShoreSearch;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.Dive;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.ExpBeach;
		}
	}

	void State_ShoreSearch(){
		textObject.text = "There's not much besides a few" +
			"\nsmall wood planks and a bit of rope." +
			"\nMaybe combined with a tree from the " +
			"\nforest you could build a raft?"+
			"\n\nPress Return to go back." +
			"\nPress D to dive.";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore2;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.Dive;
		}
	}

	void State_Dive(){
		textObject.text = "After a moment you find the ships hull." +
			"\n\nPress C to search the Captains Quarters." +
			"\nPress H to search the Cargo Hold" +
			"\nPress Return to resurface at shore.";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore2;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.Captains;
		} else if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.Hold;
		}
	}

	void State_Captains(){
		textObject.text = "Besides a cool model of the ship in a bottle," +
			"\nNothing." +
			"\n\nPress Return to resurface for more air." +
			"\nPress C to keep swimming to Cargo Hold";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore3;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.drowned;
		}
	}

	void State_drowned(){
		textObject.text = "You ran out of air and drowned."+
		"\n\nPress Return to Play Again." +
		"\nPress Escape to Close Game";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore;
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	void State_Hold(){
		textObject.text = "A shark!" +
		"\n\nPress P to punch the nose," +
		"\nPress S to swim back!";

		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.PunchedS;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.SharkDeath;
		}
	}

	void State_SharkDeath(){
		textObject.text = "You tried swimming away from a shark..." +
			"You are killed."+
			"\n\nPress Return to Play Again." +
			"\nPress Escape to Close Game";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore;
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	void State_PunchedS(){
		textObject.text = "Somehow that worked." +
			"\nThe shark swam away, thank you Nature Channel!" +
			"\nThe flares, survival gear, and canned food is all right there!" +
			"\nIf you go back up the shark could return," +
			"\nJust need to hold your breath for a second more." +
			"\n\nPress Return to resurface for more air." +
			"\nPress G to grab supplies.";
		
		if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.drowned;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore4;
		}
	}
			
	void State_shore3(){
		textObject.text = "You resurface gasping, but otherwise fine." +
			"From the beach you see Ship Wreckage and Rocks." +
			"\n\nPress W to explore Wreckage." +
			"\nPress R to explore Rocks." +
			"\nPress D to dive back."+
			"\nPress Return to go back to where you first woke up.";

		if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.Wreckage;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.Rocks;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore2;
		} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.Dive;
		}
	}

		void State_shore4(){
			textObject.text = "You resurface gasping, but otherwise fine." +
				"From the beach you see Ship Wreckage and Rocks." +
				"\n\nPress W to explore Wreckage." +
				"\nPress R to explore Rocks." +
				"\nPress D to dive back."+
				"\nPress Return to go back to where you first woke up.";

			if (Input.GetKeyDown (KeyCode.W)) {
				myState = States.Wreckage;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.Rocks;
			} else if (Input.GetKeyDown (KeyCode.Return)) {
				myState = States.shore2;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.dive2;
			}
		}

		void State_dive2(){
			textObject.text = "After a moment you find the ships hull." +
				"\n\nPress C to search the Captains Quarters." +
				"\nPress H to search the Cargo Hold" +
				"\nPress Return to resurface at shore.";

			if (Input.GetKeyDown (KeyCode.Return)) {
				myState = States.shore2;
			} else if (Input.GetKeyDown (KeyCode.C)) {
				myState = States.Captains;
			} else if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.HoldNShark;
			}
		}

	void State_HoldNShark(){
		textObject.text = "You retrieved the flares, gear, and food!" +
			"\nThe next day your flare is spotted by a Rescue boat." +
			"\nYou Live!" +
			"\n\nPress Return to Play Again." +
			"\nPress Excape to Close Game.";

		if (Input.GetKeyDown (KeyCode.Return)) {
			myState = States.shore;
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

}