using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000050 RID: 80
	public class MouseCaptureEventBase<T> : PointerCaptureEventBase<T> where T : MouseCaptureEventBase<T>, new()
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x0001BF58 File Offset: 0x0001A158
		// Note: this type is marked as 'beforefieldinit'.
		static MouseCaptureEventBase()
		{
			Il2CppClassPointerStore<MouseCaptureEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseCaptureEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseCaptureEventBase<T>>.NativeClassPtr);
			MouseCaptureEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureEventBase<T>>.NativeClassPtr, 100663694);
			MouseCaptureEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureEventBase<T>>.NativeClassPtr, 100663695);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0001BFEC File Offset: 0x0001A1EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45328, RefRangeEnd = 45330, XrefRangeStart = 45328, XrefRangeEnd = 45330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseCaptureEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0001C028 File Offset: 0x0001A228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93582, RefRangeEnd = 93584, XrefRangeStart = 93581, XrefRangeEnd = 93582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseCaptureEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseCaptureEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00004779 File Offset: 0x00002979
		public MouseCaptureEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00004782 File Offset: 0x00002982
		public new IEventHandler relatedTarget
		{
			get
			{
				return base.relatedTarget;
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0001C064 File Offset: 0x0001A264
		public static T GetPooled(IEventHandler target, IEventHandler relatedTarget)
		{
			return PointerCaptureEventBase<T>.GetPooled(target, relatedTarget, 0);
		}

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
