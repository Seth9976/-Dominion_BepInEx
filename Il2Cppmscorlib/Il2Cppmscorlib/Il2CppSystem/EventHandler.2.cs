using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x020000A2 RID: 162
	[Serializable]
	public sealed class EventHandler<TEventArgs> : MulticastDelegate
	{
		// Token: 0x06000B69 RID: 2921 RVA: 0x00055BCC File Offset: 0x00053DCC
		// Note: this type is marked as 'beforefieldinit'.
		static EventHandler()
		{
			Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EventHandler`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventArgs>.NativeClassPtr)) })).TypeHandle.value);
			EventHandler<TEventArgs>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr, 100665229);
			EventHandler<TEventArgs>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_TEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr, 100665230);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00055C58 File Offset: 0x00053E58
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventHandler<TEventArgs>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandler<TEventArgs>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00055CB4 File Offset: 0x00053EB4
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object sender, TEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TEventArgs).IsValueType)
			{
				TEventArgs teventArgs = e;
				intPtr = ((teventArgs is string) ? IL2CPP.ManagedStringToIl2Cpp(teventArgs as string) : IL2CPP.Il2CppObjectBaseToPtr(teventArgs as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref e;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventHandler<TEventArgs>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_TEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00004E79 File Offset: 0x00003079
		public EventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00004E82 File Offset: 0x00003082
		public static implicit operator EventHandler<TEventArgs>(Action<Object, TEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<EventHandler<TEventArgs>>(A_0);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00004E8A File Offset: 0x0000308A
		public static EventHandler<TEventArgs>operator +(EventHandler<TEventArgs> A_0, EventHandler<TEventArgs> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<EventHandler<TEventArgs>>();
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00004E98 File Offset: 0x00003098
		public static EventHandler<TEventArgs>operator -(EventHandler<TEventArgs> A_0, EventHandler<TEventArgs> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<EventHandler<TEventArgs>>();
			}
			return delegate2;
		}

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_TEventArgs_0;
	}
}
