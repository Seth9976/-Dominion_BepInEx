using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000002 RID: 2
	public sealed class BaselineFunction : MulticastDelegate
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002C9C File Offset: 0x00000E9C
		// Note: this type is marked as 'beforefieldinit'.
		static BaselineFunction()
		{
			Il2CppClassPointerStore<BaselineFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.Yoga", "BaselineFunction");
			BaselineFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaselineFunction>.NativeClassPtr, 100663297);
			BaselineFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_YogaNode_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaselineFunction>.NativeClassPtr, 100663298);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002CEC File Offset: 0x00000EEC
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaselineFunction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaselineFunction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaselineFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002D48 File Offset: 0x00000F48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89363, RefRangeEnd = 89365, XrefRangeStart = 89344, XrefRangeEnd = 89363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Invoke(YogaNode node, float width, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaselineFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_YogaNode_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		public BaselineFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		public static implicit operator BaselineFunction(Func<YogaNode, float, float, float> A_0)
		{
			return DelegateSupport.ConvertDelegate<BaselineFunction>(A_0);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002061 File Offset: 0x00000261
		public static BaselineFunction operator +(BaselineFunction A_0, BaselineFunction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<BaselineFunction>();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000206F File Offset: 0x0000026F
		public static BaselineFunction operator -(BaselineFunction A_0, BaselineFunction A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<BaselineFunction>();
			}
			return delegate2;
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_YogaNode_Single_Single_0;
	}
}
