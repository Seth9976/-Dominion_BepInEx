using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001BD RID: 445
	[Serializable]
	public sealed class TypeFilter : MulticastDelegate
	{
		// Token: 0x06001C54 RID: 7252 RVA: 0x000A157C File Offset: 0x0009F77C
		// Note: this type is marked as 'beforefieldinit'.
		static TypeFilter()
		{
			Il2CppClassPointerStore<TypeFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "TypeFilter");
			TypeFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeFilter>.NativeClassPtr, 100668021);
			TypeFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeFilter>.NativeClassPtr, 100668022);
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x000A15CC File Offset: 0x0009F7CC
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeFilter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x000A1628 File Offset: 0x0009F828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317358, RefRangeEnd = 317359, XrefRangeStart = 317358, XrefRangeEnd = 317358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Invoke(Type m, Object filterCriteria)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterCriteria);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00009C0D File Offset: 0x00007E0D
		public TypeFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00009C16 File Offset: 0x00007E16
		public static implicit operator TypeFilter(Func<Type, Object, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<TypeFilter>(A_0);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00009C1E File Offset: 0x00007E1E
		public static TypeFilter operator +(TypeFilter A_0, TypeFilter A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<TypeFilter>();
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00009C2C File Offset: 0x00007E2C
		public static TypeFilter operator -(TypeFilter A_0, TypeFilter A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<TypeFilter>();
			}
			return delegate2;
		}

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Type_Object_0;
	}
}
