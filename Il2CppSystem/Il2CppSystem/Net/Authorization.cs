using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000BC RID: 188
	public class Authorization : Object
	{
		// Token: 0x06000B5B RID: 2907 RVA: 0x0003B80C File Offset: 0x00039A0C
		// Note: this type is marked as 'beforefieldinit'.
		static Authorization()
		{
			Il2CppClassPointerStore<Authorization>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Authorization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Authorization>.NativeClassPtr);
			Authorization.NativeFieldInfoPtr_m_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Authorization>.NativeClassPtr, "m_Message");
			Authorization.NativeFieldInfoPtr_m_Complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Authorization>.NativeClassPtr, "m_Complete");
			Authorization.NativeFieldInfoPtr_ModuleAuthenticationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Authorization>.NativeClassPtr, "ModuleAuthenticationType");
			Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100664923);
			Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100664924);
			Authorization.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100664925);
			Authorization.NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100664926);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0003B8C8 File Offset: 0x00039AC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45824, RefRangeEnd = 45826, XrefRangeStart = 45819, XrefRangeEnd = 45824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authorization(string token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Authorization>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0003B914 File Offset: 0x00039B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45826, XrefRangeEnd = 45831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authorization(string token, bool finished)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Authorization>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finished;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0003B970 File Offset: 0x00039B70
		public unsafe string Message
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0003B9A8 File Offset: 0x00039BA8
		public unsafe bool Complete
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x000066F3 File Offset: 0x000048F3
		public Authorization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x0003B9E4 File Offset: 0x00039BE4
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x000066FC File Offset: 0x000048FC
		public unsafe string m_Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x0003BA0C File Offset: 0x00039C0C
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x0000671B File Offset: 0x0000491B
		public unsafe bool m_Complete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Complete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Complete)) = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0003BA34 File Offset: 0x00039C34
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00006736 File Offset: 0x00004936
		public unsafe string ModuleAuthenticationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_ModuleAuthenticationType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_ModuleAuthenticationType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeFieldInfoPtr_m_Message;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeFieldInfoPtr_m_Complete;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeFieldInfoPtr_ModuleAuthenticationType;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0;
	}
}
