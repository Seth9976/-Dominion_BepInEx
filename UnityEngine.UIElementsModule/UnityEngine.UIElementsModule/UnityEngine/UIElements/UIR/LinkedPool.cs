using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000CF RID: 207
	public class LinkedPool<T> : Object where T : LinkedPoolItem<T>
	{
		// Token: 0x06000B9C RID: 2972 RVA: 0x00030430 File Offset: 0x0002E630
		// Note: this type is marked as 'beforefieldinit'.
		static LinkedPool()
		{
			Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "LinkedPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr);
			LinkedPool<T>.NativeFieldInfoPtr_m_CreateFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, "m_CreateFunc");
			LinkedPool<T>.NativeFieldInfoPtr_m_ResetAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, "m_ResetAction");
			LinkedPool<T>.NativeFieldInfoPtr_m_Limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, "m_Limit");
			LinkedPool<T>.NativeFieldInfoPtr_m_PoolFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, "m_PoolFirst");
			LinkedPool<T>.NativeFieldInfoPtr__Count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPool<T>>.NativeClassPtr, "<Count>k__BackingField");
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0000746D File Offset: 0x0000566D
		public LinkedPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x00030500 File Offset: 0x0002E700
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x00007476 File Offset: 0x00005676
		public unsafe Func<T> m_CreateFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_CreateFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_CreateFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x00030530 File Offset: 0x0002E730
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x00007495 File Offset: 0x00005695
		public unsafe Action<T> m_ResetAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_ResetAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_ResetAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x00030560 File Offset: 0x0002E760
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x000074B4 File Offset: 0x000056B4
		public unsafe int m_Limit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_Limit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_Limit)) = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x00030588 File Offset: 0x0002E788
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x000305B0 File Offset: 0x0002E7B0
		public unsafe T m_PoolFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_PoolFirst);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr_m_PoolFirst);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x00030658 File Offset: 0x0002E858
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x000074CF File Offset: 0x000056CF
		public unsafe int _Count_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr__Count_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPool<T>.NativeFieldInfoPtr__Count_k__BackingField)) = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x000074EA File Offset: 0x000056EA
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x000074F2 File Offset: 0x000056F2
		public int Count
		{
			get
			{
				return this._Count_k__BackingField;
			}
			set
			{
				this._Count_k__BackingField = value;
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000074FB File Offset: 0x000056FB
		public void Clear()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00007508 File Offset: 0x00005708
		public T Get()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00030680 File Offset: 0x0002E880
		public void Return(T item)
		{
			bool flag = this.Count < this.m_Limit;
			if (flag)
			{
				item.poolNext = this.m_PoolFirst;
				this.m_PoolFirst = item;
				int num = this.Count + 1;
				this.Count = num;
			}
		}

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateFunc;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeFieldInfoPtr_m_ResetAction;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeFieldInfoPtr_m_Limit;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeFieldInfoPtr_m_PoolFirst;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeFieldInfoPtr__Count_k__BackingField;
	}
}
