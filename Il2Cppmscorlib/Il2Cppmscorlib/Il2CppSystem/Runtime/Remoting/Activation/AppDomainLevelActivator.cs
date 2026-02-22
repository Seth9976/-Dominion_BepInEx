using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D1 RID: 977
	public class AppDomainLevelActivator : Object
	{
		// Token: 0x06003E6E RID: 15982 RVA: 0x00123AD8 File Offset: 0x00121CD8
		// Note: this type is marked as 'beforefieldinit'.
		static AppDomainLevelActivator()
		{
			Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "AppDomainLevelActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr);
			AppDomainLevelActivator.NativeFieldInfoPtr__activationUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, "_activationUrl");
			AppDomainLevelActivator.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, "_next");
			AppDomainLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_String_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, 100672467);
			AppDomainLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, 100672468);
			AppDomainLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, 100672469);
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x00123B6C File Offset: 0x00121D6C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomainLevelActivator(string activationUrl, IActivator next)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(activationUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_String_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06003E70 RID: 15984 RVA: 0x00123BCC File Offset: 0x00121DCC
		public unsafe virtual IActivator NextActivator
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x00123C0C File Offset: 0x00121E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353799, XrefRangeEnd = 353834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x000178BE File Offset: 0x00015ABE
		public AppDomainLevelActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06003E73 RID: 15987 RVA: 0x00123C5C File Offset: 0x00121E5C
		// (set) Token: 0x06003E74 RID: 15988 RVA: 0x000178C7 File Offset: 0x00015AC7
		public unsafe string _activationUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__activationUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__activationUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06003E75 RID: 15989 RVA: 0x00123C84 File Offset: 0x00121E84
		// (set) Token: 0x06003E76 RID: 15990 RVA: 0x000178E6 File Offset: 0x00015AE6
		public unsafe IActivator _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003375 RID: 13173
		private static readonly IntPtr NativeFieldInfoPtr__activationUrl;

		// Token: 0x04003376 RID: 13174
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x04003377 RID: 13175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IActivator_0;

		// Token: 0x04003378 RID: 13176
		private static readonly IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0;

		// Token: 0x04003379 RID: 13177
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0;
	}
}
