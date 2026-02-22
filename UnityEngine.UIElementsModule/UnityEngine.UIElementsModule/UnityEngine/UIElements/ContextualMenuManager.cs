using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000007 RID: 7
	public class ContextualMenuManager : Object
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002233 File Offset: 0x00000433
		// Note: this type is marked as 'beforefieldinit'.
		static ContextualMenuManager()
		{
			Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ContextualMenuManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr);
			ContextualMenuManager.NativeFieldInfoPtr__displayMenuHandledOSX_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr, "<displayMenuHandledOSX>k__BackingField");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000226C File Offset: 0x0000046C
		public ContextualMenuManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000D108 File Offset: 0x0000B308
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002275 File Offset: 0x00000475
		public unsafe bool _displayMenuHandledOSX_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuManager.NativeFieldInfoPtr__displayMenuHandledOSX_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuManager.NativeFieldInfoPtr__displayMenuHandledOSX_k__BackingField)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002290 File Offset: 0x00000490
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002298 File Offset: 0x00000498
		public bool displayMenuHandledOSX
		{
			get
			{
				return this._displayMenuHandledOSX_k__BackingField;
			}
			set
			{
				this._displayMenuHandledOSX_k__BackingField = value;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000D130 File Offset: 0x0000B330
		public void DisplayMenu(EventBase triggerEvent, IEventHandler target)
		{
			DropdownMenu dropdownMenu = new DropdownMenu();
			using (ContextualMenuPopulateEvent pooled = ContextualMenuPopulateEvent.GetPooled(triggerEvent, dropdownMenu, target, this))
			{
				if (target != null)
				{
					target.SendEvent(pooled);
				}
			}
			bool flag = Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer;
			if (flag)
			{
				this.displayMenuHandledOSX = true;
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr__displayMenuHandledOSX_k__BackingField;
	}
}
