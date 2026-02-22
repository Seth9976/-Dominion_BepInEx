using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005C RID: 92
	public sealed class EventCallback<TEventType> : MulticastDelegate
	{
		// Token: 0x060005E6 RID: 1510 RVA: 0x0001E89C File Offset: 0x0001CA9C
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallback()
		{
			Il2CppClassPointerStore<EventCallback<TEventType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallback`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) })).TypeHandle.value);
			EventCallback<TEventType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallback<TEventType>>.NativeClassPtr, 100663794);
			EventCallback<TEventType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallback<TEventType>>.NativeClassPtr, 100663795);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0001E928 File Offset: 0x0001CB28
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallback<TEventType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallback<TEventType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0001E984 File Offset: 0x0001CB84
		[CallerCount(277)]
		[CachedScanResults(RefRangeStart = 94180, RefRangeEnd = 94457, XrefRangeStart = 94163, XrefRangeEnd = 94180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(TEventType evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TEventType).IsValueType)
				{
					TEventType teventType = evt;
					intPtr = ((teventType is string) ? IL2CPP.ManagedStringToIl2Cpp(teventType as string) : IL2CPP.Il2CppObjectBaseToPtr(teventType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref evt;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventCallback<TEventType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00004BA8 File Offset: 0x00002DA8
		public EventCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00004BB1 File Offset: 0x00002DB1
		public static implicit operator EventCallback<TEventType>(Action<TEventType> A_0)
		{
			return DelegateSupport.ConvertDelegate<EventCallback<TEventType>>(A_0);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00004BB9 File Offset: 0x00002DB9
		public static EventCallback<TEventType>operator +(EventCallback<TEventType> A_0, EventCallback<TEventType> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<EventCallback<TEventType>>();
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00004BC7 File Offset: 0x00002DC7
		public static EventCallback<TEventType>operator -(EventCallback<TEventType> A_0, EventCallback<TEventType> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<EventCallback<TEventType>>();
			}
			return delegate2;
		}

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TEventType_0;
	}
}
