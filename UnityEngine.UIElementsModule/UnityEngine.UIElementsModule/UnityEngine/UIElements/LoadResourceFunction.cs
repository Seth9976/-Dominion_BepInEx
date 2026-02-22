using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001D RID: 29
	public sealed class LoadResourceFunction : MulticastDelegate
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x00011CF8 File Offset: 0x0000FEF8
		// Note: this type is marked as 'beforefieldinit'.
		static LoadResourceFunction()
		{
			Il2CppClassPointerStore<LoadResourceFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "LoadResourceFunction");
			LoadResourceFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadResourceFunction>.NativeClassPtr, 100663439);
			LoadResourceFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_String_Type_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadResourceFunction>.NativeClassPtr, 100663440);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00011D48 File Offset: 0x0000FF48
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadResourceFunction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadResourceFunction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadResourceFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00011DA4 File Offset: 0x0000FFA4
		[CallerCount(0)]
		public unsafe Object Invoke(string pathName, Type type, float dpiScaling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dpiScaling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadResourceFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_String_Type_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002DA8 File Offset: 0x00000FA8
		public LoadResourceFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002DB1 File Offset: 0x00000FB1
		public static implicit operator LoadResourceFunction(Func<string, Type, float, Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<LoadResourceFunction>(A_0);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002DB9 File Offset: 0x00000FB9
		public static LoadResourceFunction operator +(LoadResourceFunction A_0, LoadResourceFunction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<LoadResourceFunction>();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002DC7 File Offset: 0x00000FC7
		public static LoadResourceFunction operator -(LoadResourceFunction A_0, LoadResourceFunction A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<LoadResourceFunction>();
			}
			return delegate2;
		}

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_String_Type_Single_0;
	}
}
