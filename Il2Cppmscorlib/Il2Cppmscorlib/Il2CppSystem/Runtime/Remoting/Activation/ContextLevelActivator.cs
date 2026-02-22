using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D3 RID: 979
	[Serializable]
	public class ContextLevelActivator : Object
	{
		// Token: 0x06003E7C RID: 15996 RVA: 0x00123DEC File Offset: 0x00121FEC
		// Note: this type is marked as 'beforefieldinit'.
		static ContextLevelActivator()
		{
			Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "ContextLevelActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr);
			ContextLevelActivator.NativeFieldInfoPtr_m_NextActivator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, "m_NextActivator");
			ContextLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, 100672473);
			ContextLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, 100672474);
			ContextLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, 100672475);
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x00123E6C File Offset: 0x0012206C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextLevelActivator(IActivator next)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x00123EB8 File Offset: 0x001220B8
		public unsafe virtual IActivator NextActivator
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x00123EF8 File Offset: 0x001220F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353841, XrefRangeEnd = 353863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x0001790E File Offset: 0x00015B0E
		public ContextLevelActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06003E81 RID: 16001 RVA: 0x00123F48 File Offset: 0x00122148
		// (set) Token: 0x06003E82 RID: 16002 RVA: 0x00017917 File Offset: 0x00015B17
		public unsafe IActivator m_NextActivator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextLevelActivator.NativeFieldInfoPtr_m_NextActivator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextLevelActivator.NativeFieldInfoPtr_m_NextActivator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400337D RID: 13181
		private static readonly IntPtr NativeFieldInfoPtr_m_NextActivator;

		// Token: 0x0400337E RID: 13182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IActivator_0;

		// Token: 0x0400337F RID: 13183
		private static readonly IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0;

		// Token: 0x04003380 RID: 13184
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0;
	}
}
