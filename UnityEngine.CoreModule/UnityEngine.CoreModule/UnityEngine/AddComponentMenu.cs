using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A1 RID: 161
	public sealed class AddComponentMenu : Attribute
	{
		// Token: 0x06000FD7 RID: 4055 RVA: 0x00041870 File Offset: 0x0003FA70
		// Note: this type is marked as 'beforefieldinit'.
		static AddComponentMenu()
		{
			Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AddComponentMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr);
			AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, "m_AddComponentMenu");
			AddComponentMenu.NativeFieldInfoPtr_m_Ordering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, "m_Ordering");
			AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100664324);
			AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100664325);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x000418F0 File Offset: 0x0003FAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68298, XrefRangeEnd = 68299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddComponentMenu(string menuName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0004193C File Offset: 0x0003FB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddComponentMenu(string menuName, int order)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00009DDC File Offset: 0x00007FDC
		public AddComponentMenu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00041998 File Offset: 0x0003FB98
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00009DE5 File Offset: 0x00007FE5
		public unsafe string m_AddComponentMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x000419C0 File Offset: 0x0003FBC0
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x00009E04 File Offset: 0x00008004
		public unsafe int m_Ordering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_Ordering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_Ordering)) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x000419E8 File Offset: 0x0003FBE8
		public string componentMenu
		{
			get
			{
				return this.m_AddComponentMenu;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00041A00 File Offset: 0x0003FC00
		public int componentOrder
		{
			get
			{
				return this.m_Ordering;
			}
		}

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeFieldInfoPtr_m_AddComponentMenu;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeFieldInfoPtr_m_Ordering;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}
