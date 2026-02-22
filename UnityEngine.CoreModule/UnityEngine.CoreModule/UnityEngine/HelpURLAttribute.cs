using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A6 RID: 166
	public class HelpURLAttribute : Attribute
	{
		// Token: 0x06000FEC RID: 4076 RVA: 0x00041ACC File Offset: 0x0003FCCC
		// Note: this type is marked as 'beforefieldinit'.
		static HelpURLAttribute()
		{
			Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HelpURLAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr);
			HelpURLAttribute.NativeFieldInfoPtr_m_Url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_Url");
			HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_Dispatcher");
			HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, "m_DispatchingFieldName");
			HelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, 100664329);
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00041B4C File Offset: 0x0003FD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68299, XrefRangeEnd = 68302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelpURLAttribute(string url)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00009F13 File Offset: 0x00008113
		public HelpURLAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00041B98 File Offset: 0x0003FD98
		// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x00009F1C File Offset: 0x0000811C
		public unsafe string m_Url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x00041BC0 File Offset: 0x0003FDC0
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x00009F3B File Offset: 0x0000813B
		public unsafe bool m_Dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher)) = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00041BE8 File Offset: 0x0003FDE8
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00009F56 File Offset: 0x00008156
		public unsafe string m_DispatchingFieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00009F75 File Offset: 0x00008175
		public string URL
		{
			get
			{
				return this.m_Url;
			}
		}

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeFieldInfoPtr_m_Url;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeFieldInfoPtr_m_Dispatcher;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeFieldInfoPtr_m_DispatchingFieldName;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
