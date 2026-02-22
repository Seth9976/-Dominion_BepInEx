using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.AndroidNative.DynamicLinks
{
	// Token: 0x0200034F RID: 847
	[Serializable]
	public class LinkEditorTemplate : Object
	{
		// Token: 0x0600332F RID: 13103 RVA: 0x000D5500 File Offset: 0x000D3700
		// Note: this type is marked as 'beforefieldinit'.
		static LinkEditorTemplate()
		{
			Il2CppClassPointerStore<LinkEditorTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.AndroidNative.DynamicLinks", "LinkEditorTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkEditorTemplate>.NativeClassPtr);
			LinkEditorTemplate.NativeFieldInfoPtr_Host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkEditorTemplate>.NativeClassPtr, "Host");
			LinkEditorTemplate.NativeFieldInfoPtr_Scheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkEditorTemplate>.NativeClassPtr, "Scheme");
			LinkEditorTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkEditorTemplate>.NativeClassPtr, 100669857);
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x000D556C File Offset: 0x000D376C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223517, XrefRangeEnd = 223521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkEditorTemplate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkEditorTemplate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkEditorTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x00013E6D File Offset: 0x0001206D
		public LinkEditorTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06003332 RID: 13106 RVA: 0x000D55A8 File Offset: 0x000D37A8
		// (set) Token: 0x06003333 RID: 13107 RVA: 0x00013E76 File Offset: 0x00012076
		public unsafe string Host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkEditorTemplate.NativeFieldInfoPtr_Host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkEditorTemplate.NativeFieldInfoPtr_Host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06003334 RID: 13108 RVA: 0x000D55D0 File Offset: 0x000D37D0
		// (set) Token: 0x06003335 RID: 13109 RVA: 0x00013E95 File Offset: 0x00012095
		public unsafe string Scheme
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkEditorTemplate.NativeFieldInfoPtr_Scheme);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkEditorTemplate.NativeFieldInfoPtr_Scheme), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002FAF RID: 12207
		private static readonly IntPtr NativeFieldInfoPtr_Host;

		// Token: 0x04002FB0 RID: 12208
		private static readonly IntPtr NativeFieldInfoPtr_Scheme;

		// Token: 0x04002FB1 RID: 12209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
