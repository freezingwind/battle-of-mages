﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace BoM.UI {
	// FormAction
	public class FormAction : MonoBehaviour {
		public Button button;
		private EventSystem system;

		// Start
		void Start() {
			system = EventSystem.current;
		}

		// Update
		void Update() {
			if(UnityEngine.Input.GetKeyDown(KeyCode.Return) && button.interactable) {
				var selected = system.currentSelectedGameObject;

				if(!selected)
					return;

				if(selected != this.gameObject && !selected.transform.IsChildOf(this.transform))
					return;

				button.OnSubmit(new PointerEventData(system));
			}
		}
	}
}