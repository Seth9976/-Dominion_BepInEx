using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004C RID: 76
	public class Foldout : BindableElement
	{
		// Token: 0x0600050A RID: 1290 RVA: 0x0001BA20 File Offset: 0x00019C20
		// Note: this type is marked as 'beforefieldinit'.
		static Foldout()
		{
			Il2CppClassPointerStore<Foldout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Foldout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Foldout>.NativeClassPtr);
			Foldout.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "ussClassName");
			Foldout.NativeFieldInfoPtr_toggleUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "toggleUssClassName");
			Foldout.NativeFieldInfoPtr_contentUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "contentUssClassName");
			Foldout.NativeFieldInfoPtr_ussFoldoutDepthClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "ussFoldoutDepthClassName");
			Foldout.NativeFieldInfoPtr_ussFoldoutMaxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "ussFoldoutMaxDepth");
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000045E8 File Offset: 0x000027E8
		public Foldout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0001BAB4 File Offset: 0x00019CB4
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x000045F1 File Offset: 0x000027F1
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0001BAD4 File Offset: 0x00019CD4
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00004603 File Offset: 0x00002803
		public unsafe static string toggleUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_toggleUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_toggleUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0001BAF4 File Offset: 0x00019CF4
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00004615 File Offset: 0x00002815
		public unsafe static string contentUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_contentUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_contentUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0001BB14 File Offset: 0x00019D14
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00004627 File Offset: 0x00002827
		public unsafe static string ussFoldoutDepthClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_ussFoldoutDepthClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_ussFoldoutDepthClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0001BB34 File Offset: 0x00019D34
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00004639 File Offset: 0x00002839
		public unsafe static int ussFoldoutMaxDepth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_ussFoldoutMaxDepth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_ussFoldoutMaxDepth, (void*)(&value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00004647 File Offset: 0x00002847
		public override VisualElement contentContainer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00004654 File Offset: 0x00002854
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00004661 File Offset: 0x00002861
		public string text
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0000466E File Offset: 0x0000286E
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0000467B File Offset: 0x0000287B
		public bool value
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00004688 File Offset: 0x00002888
		public void SetValueWithoutNotify(bool newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00004695 File Offset: 0x00002895
		public override void OnViewDataReady()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001BB50 File Offset: 0x00019D50
		public void OnAttachToPanel(AttachToPanelEvent evt)
		{
			for (int i = 0; i <= Foldout.ussFoldoutMaxDepth; i++)
			{
				base.RemoveFromClassList(String.Concat(Foldout.ussFoldoutDepthClassName, i.ToString()));
			}
			base.RemoveFromClassList(String.Concat(Foldout.ussFoldoutDepthClassName, "max"));
			int foldoutDepth = VisualElementUtils.GetFoldoutDepth(this);
			bool flag = foldoutDepth > Foldout.ussFoldoutMaxDepth;
			if (flag)
			{
				base.AddToClassList(String.Concat(Foldout.ussFoldoutDepthClassName, "max"));
			}
			else
			{
				base.AddToClassList(String.Concat(Foldout.ussFoldoutDepthClassName, foldoutDepth.ToString()));
			}
		}

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_toggleUssClassName;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_contentUssClassName;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_ussFoldoutDepthClassName;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr_ussFoldoutMaxDepth;

		// Token: 0x0200020C RID: 524
		public new class UxmlFactory : UxmlFactory<Foldout, Foldout.UxmlTraits>
		{
		}

		// Token: 0x0200020D RID: 525
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
		}
	}
}
