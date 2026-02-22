using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001AA RID: 426
	[Serializable]
	public sealed class MemberFilter : MulticastDelegate
	{
		// Token: 0x06001BC6 RID: 7110 RVA: 0x0009ED6C File Offset: 0x0009CF6C
		// Note: this type is marked as 'beforefieldinit'.
		static MemberFilter()
		{
			Il2CppClassPointerStore<MemberFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MemberFilter");
			MemberFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberFilter>.NativeClassPtr, 100667931);
			MemberFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_MemberInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberFilter>.NativeClassPtr, 100667932);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0009EDBC File Offset: 0x0009CFBC
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberFilter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0009EE18 File Offset: 0x0009D018
		[CallerCount(0)]
		public unsafe bool Invoke(MemberInfo m, Object filterCriteria)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_MemberInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000099C2 File Offset: 0x00007BC2
		public MemberFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x000099CB File Offset: 0x00007BCB
		public static implicit operator MemberFilter(Func<MemberInfo, Object, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<MemberFilter>(A_0);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x000099D3 File Offset: 0x00007BD3
		public static MemberFilter operator +(MemberFilter A_0, MemberFilter A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MemberFilter>();
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x000099E1 File Offset: 0x00007BE1
		public static MemberFilter operator -(MemberFilter A_0, MemberFilter A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MemberFilter>();
			}
			return delegate2;
		}

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_MemberInfo_Object_0;
	}
}
