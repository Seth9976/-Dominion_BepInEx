using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000086 RID: 134
	public class NavigationEventBase<T> : EventBase<T> where T : NavigationEventBase<T>, new()
	{
		// Token: 0x06000744 RID: 1860 RVA: 0x00023B84 File Offset: 0x00021D84
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationEventBase()
		{
			Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "NavigationEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr);
			NavigationEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100663979);
			NavigationEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100663980);
			NavigationEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100663981);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00023C2C File Offset: 0x00021E2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 95703, RefRangeEnd = 95707, XrefRangeStart = 95698, XrefRangeEnd = 95703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00023C68 File Offset: 0x00021E68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95708, RefRangeEnd = 95710, XrefRangeStart = 95707, XrefRangeEnd = 95708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NavigationEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00023CA4 File Offset: 0x00021EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95710, XrefRangeEnd = 95712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000051F8 File Offset: 0x000033F8
		public NavigationEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;
	}
}
