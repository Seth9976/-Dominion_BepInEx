using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001F RID: 31
	public sealed class GetViewDataDictionary : MulticastDelegate
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x00011EFC File Offset: 0x000100FC
		// Note: this type is marked as 'beforefieldinit'.
		static GetViewDataDictionary()
		{
			Il2CppClassPointerStore<GetViewDataDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "GetViewDataDictionary");
			GetViewDataDictionary.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetViewDataDictionary>.NativeClassPtr, 100663443);
			GetViewDataDictionary.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISerializableJsonDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetViewDataDictionary>.NativeClassPtr, 100663444);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00011F4C File Offset: 0x0001014C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetViewDataDictionary(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetViewDataDictionary>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetViewDataDictionary.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00011FA8 File Offset: 0x000101A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91949, RefRangeEnd = 91951, XrefRangeStart = 91949, XrefRangeEnd = 91951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISerializableJsonDictionary Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetViewDataDictionary.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISerializableJsonDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializableJsonDictionary>(intPtr3) : null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002E08 File Offset: 0x00001008
		public GetViewDataDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002E11 File Offset: 0x00001011
		public static implicit operator GetViewDataDictionary(Func<ISerializableJsonDictionary> A_0)
		{
			return DelegateSupport.ConvertDelegate<GetViewDataDictionary>(A_0);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002E19 File Offset: 0x00001019
		public static GetViewDataDictionary operator +(GetViewDataDictionary A_0, GetViewDataDictionary A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GetViewDataDictionary>();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002E27 File Offset: 0x00001027
		public static GetViewDataDictionary operator -(GetViewDataDictionary A_0, GetViewDataDictionary A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GetViewDataDictionary>();
			}
			return delegate2;
		}

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISerializableJsonDictionary_0;
	}
}
