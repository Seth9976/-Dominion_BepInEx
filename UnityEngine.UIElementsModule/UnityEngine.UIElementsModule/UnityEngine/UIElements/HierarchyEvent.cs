using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001A RID: 26
	public sealed class HierarchyEvent : MulticastDelegate
	{
		// Token: 0x06000141 RID: 321 RVA: 0x00010964 File Offset: 0x0000EB64
		// Note: this type is marked as 'beforefieldinit'.
		static HierarchyEvent()
		{
			Il2CppClassPointerStore<HierarchyEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "HierarchyEvent");
			HierarchyEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyEvent>.NativeClassPtr, 100663403);
			HierarchyEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisualElement_HierarchyChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyEvent>.NativeClassPtr, 100663404);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000109B4 File Offset: 0x0000EBB4
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HierarchyEvent(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00010A10 File Offset: 0x0000EC10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 90246, RefRangeEnd = 90249, XrefRangeStart = 90246, XrefRangeEnd = 90249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(VisualElement ve, HierarchyChangeType changeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisualElement_HierarchyChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002A20 File Offset: 0x00000C20
		public HierarchyEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002A29 File Offset: 0x00000C29
		public static implicit operator HierarchyEvent(Action<VisualElement, HierarchyChangeType> A_0)
		{
			return DelegateSupport.ConvertDelegate<HierarchyEvent>(A_0);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002A31 File Offset: 0x00000C31
		public static HierarchyEvent operator +(HierarchyEvent A_0, HierarchyEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<HierarchyEvent>();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002A3F File Offset: 0x00000C3F
		public static HierarchyEvent operator -(HierarchyEvent A_0, HierarchyEvent A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<HierarchyEvent>();
			}
			return delegate2;
		}

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisualElement_HierarchyChangeType_0;
	}
}
