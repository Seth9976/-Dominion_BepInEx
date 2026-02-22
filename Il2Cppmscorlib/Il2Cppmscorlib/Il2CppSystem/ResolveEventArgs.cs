using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200012C RID: 300
	public class ResolveEventArgs : EventArgs
	{
		// Token: 0x06001594 RID: 5524 RVA: 0x0008416C File Offset: 0x0008236C
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveEventArgs()
		{
			Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ResolveEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr);
			ResolveEventArgs.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, "m_Name");
			ResolveEventArgs.NativeFieldInfoPtr_m_Requesting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, "m_Requesting");
			ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, 100666960);
			ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, 100666961);
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x000841EC File Offset: 0x000823EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307902, RefRangeEnd = 307903, XrefRangeStart = 307898, XrefRangeEnd = 307902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveEventArgs(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00084238 File Offset: 0x00082438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307907, RefRangeEnd = 307909, XrefRangeStart = 307903, XrefRangeEnd = 307907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveEventArgs(string name, Assembly requestingAssembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestingAssembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x000077A7 File Offset: 0x000059A7
		public ResolveEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x00084298 File Offset: 0x00082498
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x000077B0 File Offset: 0x000059B0
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x000842C0 File Offset: 0x000824C0
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x000077CF File Offset: 0x000059CF
		public unsafe Assembly m_Requesting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr_m_Requesting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr_m_Requesting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeFieldInfoPtr_m_Requesting;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0;
	}
}
