using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000096 RID: 150
	public sealed class PointerDownEvent : PointerEventBase<PointerDownEvent>
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x000272F0 File Offset: 0x000254F0
		// Note: this type is marked as 'beforefieldinit'.
		static PointerDownEvent()
		{
			Il2CppClassPointerStore<PointerDownEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerDownEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerDownEvent>.NativeClassPtr);
			PointerDownEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownEvent>.NativeClassPtr, 100664096);
			PointerDownEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownEvent>.NativeClassPtr, 100664097);
			PointerDownEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownEvent>.NativeClassPtr, 100664098);
			PointerDownEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDownEvent>.NativeClassPtr, 100664099);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00027370 File Offset: 0x00025570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96274, XrefRangeEnd = 96280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000273A4 File Offset: 0x000255A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96280, XrefRangeEnd = 96283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000273D8 File Offset: 0x000255D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96283, XrefRangeEnd = 96289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerDownEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerDownEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00027414 File Offset: 0x00025614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96289, XrefRangeEnd = 96311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDownEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0000574F File Offset: 0x0000394F
		public PointerDownEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;
	}
}
